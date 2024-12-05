using System;

namespace RetailWay.Integration.OfdRu.DataModels
{
    public struct Receipt
    {
        public Guid Id { get; set; }
        public DateTime CDateUtc { get; set; }
        public int Tag { get; set; }
        public bool IsBso { get; set; }
        public bool IsCorrection { get; set; }
        public string OperationType { get; set; }
        public string UserInn { get; set; }
        public string KktRegNumber { get; set; }
        public string FnNumber { get; set; }
        public int DocNumber { get; set; }
        public DateTime DocDateTime { get; set; }
        public int DocShiftNumber { get; set; }
        public int ReceiptNumber { get; set; }
        public Guid DocRawId { get; set; }
        public int TotalSumm { get; set; }
        public int CashSumm { get; set; }
        public int ECashSumm { get; set; }
        public int PrepaidSumm { get; set; }
        public int CreditSumm { get; set; }
        public int ProvisionSumm { get; set; }
        public int TaxTotalSumm { get; set; }
        public int Tax10Summ { get; set; }
        public int Tax18Summ { get; set; }
        public int Tax110Summ { get; set; }
        public int Tax118Summ { get; set; }
        public int TaxNaSumm { get; set; }
        public int Tax0Summ { get; set; }
        public int Depth { get; set; }
    }
}
