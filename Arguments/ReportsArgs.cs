using RetailWay.Integration.OfdRu.Exceptions;
using System;
using System.Text;

namespace RetailWay.Integration.OfdRu.Arguments
{
    public readonly struct ReportsArgs : IArgs
    {
        public string Address { get; }

        public ReportsArgs(string vatin, DateTime begin, DateTime end, string reg = null)
        {
            PeriodOverflowException.ThrowIfGreatThanMonth(begin, end);

            var builder = new StringBuilder($"inn/{vatin}/zreports");
            if (!(reg is null))
                builder.Insert(builder.Length - 9, $"kkt/{reg}/");
            builder.InsertPeriod(begin, end, '?');
            Address = builder.ToString();
        }
    }
}
