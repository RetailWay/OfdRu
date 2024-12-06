using System;

namespace RetailWay.Integration.OfdRu.Arguments
{
    public readonly struct ReceiptDetailArgs : IArgs
    {
        public string Address { get; }

        public ReceiptDetailArgs(string vatin, string reg, Guid receipt)
        {
            Address = $"inn/{vatin}/kkt/{reg}/receipt/{receipt:D}";
        }

        public ReceiptDetailArgs(string vatin, string reg, int session, int receipt)
        {
            Address = $"inn/{vatin}/kkt/{reg}/zreport/{session}/receipt/{receipt}";
        }
    }
}
