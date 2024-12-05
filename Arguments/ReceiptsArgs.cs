using RetailWay.Integration.OfdRu.Exceptions;
using System;
using System.Text;

namespace RetailWay.Integration.OfdRu.Arguments
{
    public readonly struct ReceiptsArgs : IArgs
    {
        public string Address { get; }

        public ReceiptsArgs(string vatin, string reg, DateTime begin, DateTime end)
        {
            PeriodOverflowException.ThrowIfGreatThanMonth(begin, end);

            var builder = new StringBuilder($"inn/{vatin}/kkt/{reg}/receipts?");
            builder.InsertPeriod(begin, end, '\0');
            Address = builder.ToString();
        }

        public ReceiptsArgs(string vatin, string reg, string storage, int session)
        {
            Address = $"inn/{vatin}/kkt/{reg}/receipts?ShiftNumber={session}&FnNumber={storage}";
        }

    }
}
