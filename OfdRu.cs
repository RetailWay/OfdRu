using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RetailWay.Integration.OfdRu.Arguments;
using RetailWay.Integration.OfdRu.DataModels;

namespace RetailWay.Integration.OfdRu
{
    public class OfdRu
    {
        internal const string FORMAT_DATE = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

        private readonly HttpClient _client;
        private readonly string _token;
        private readonly JsonSerializerSettings _optionsSerializer;

        public OfdRu(string token)
        {
            _token = token;
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://ofd.ru/api/integration/v2/"),
                Timeout = TimeSpan.FromSeconds(3),
                DefaultRequestHeaders = { 
                    { "Content-Type", "application/json; charset=utf-8" } 
                }
            };
            _optionsSerializer = new JsonSerializerSettings
            {
                DateFormatString = FORMAT_DATE,
            };
        }

        public async Task<T> SendAsync<T>(string address, string body = null)
        {
            address += $"{(string.IsNullOrEmpty(new Uri(address).Query) ? "?" : "&")}AuthToken={_token}";
            var req = new HttpRequestMessage(body is null ? HttpMethod.Get : HttpMethod.Post, address);
            if (!(body is null))
                req.Content = new StringContent(body);
            var resp = await _client.SendAsync(req);
            await Task.Delay(1000);
            var respBody = await resp.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Response<T>>(respBody, _optionsSerializer);
            if (json.Status != "Success")
                throw new Exception(string.Join("; ", json.Errors));
            return json.Data;
        }

        public async Task<DeviceInfo> GetDeviceInfo(DeviceInfoArgs args) => 
            await SendAsync<DeviceInfo>(args.Address);

        public async Task<Report[]> GetReports(ReportsArgs args) =>
            await SendAsync<Report[]>(args.Address);

        public async Task<Receipt[]> GetReceipts(ReceiptsArgs args) =>
            await SendAsync<Receipt[]>(args.Address);

        public async Task<ReceiptDetail> GetReceiptDetail(ReceiptsArgs args) =>
            await SendAsync<ReceiptDetail>(args.Address);
    }
}