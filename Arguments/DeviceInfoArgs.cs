using System;
using System.Text;

namespace RetailWay.Integration.OfdRu.Arguments
{
    public readonly struct DeviceInfoArgs : IArgs
    {
        public string Address { get; }

        public DeviceInfoArgs(string vatin, string storage = null, string serial = null, string reg = null)
        {
            if (storage is null && serial is null && reg is null)
                throw new ArgumentException($"Необходимо заполнить хотя бы один из следующих " +
                    $"параметров: {nameof(vatin)}, {nameof(serial)}, {nameof(reg)}");

            var builder = new StringBuilder($"inn/{vatin}/kkts?");
            if (!(storage is null)) builder.Append($"FNSerialNumber={storage}&");
            if (!(reg is null)) builder.Append($"KKTRegNumber={reg}&");
            if (!(serial is null)) builder.Append($"KKTSerialNumber={serial}&");
            builder.Remove(builder.Length - 1, 1);
            Address = builder.ToString();
        }
    }
}
