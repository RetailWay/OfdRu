using System;

namespace RetailWay.Integration.OfdRu
{
    public struct Response<T>
    {
        public string Status { get; set; }
        public T Data { get; set; }
        public string[] Errors { get; set; }
        public TimeSpan Elapsed { get; set; }
    }
}
