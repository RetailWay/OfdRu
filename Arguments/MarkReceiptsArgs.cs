using RetailWay.Integration.OfdRu.Exceptions;
using System;
using System.Text;

namespace RetailWay.Integration.OfdRu.Arguments
{
    public readonly struct MarkReceiptsArgs : IArgs
    {
        public string Address { get; }

        public MarkReceiptsArgs(string vatin, string reg, DateTime begin, DateTime end)
        {
            PeriodOverflowException.ThrowIfGreatThanMonth(begin, end);

            var builder = new StringBuilder();
            builder.Append($"inn/{vatin}/kkt/{reg}/receipts-info");
            builder.InsertPeriod(begin, end, '?');
            Address = builder.ToString();
        }
    }
}
