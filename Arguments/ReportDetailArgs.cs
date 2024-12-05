using System;

namespace RetailWay.Integration.OfdRu.Arguments
{
    public readonly struct ReportDetailArgs : IArgs
    {
        public string Address { get; }

        public ReportDetailArgs(string vatin, string reg, Guid receipt)
        {
            Address = $"inn/{vatin}/kkt/{reg}/receipt/{receipt:D}";
        }

        public ReportDetailArgs(string vatin, string reg, int session, int receipt)
        {
            Address = $"inn/{vatin}/kkt/{reg}/zreport/{session}/receipt/{receipt}";
        }
    }
}
