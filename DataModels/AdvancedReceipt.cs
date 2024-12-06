using System;

namespace RetailWay.Integration.OfdRu.DataModels
{
    public struct AdvancedReceipt
    {
        public Guid Id { get; set; }        
        public DateTime CDateUtc { get; set; }        
        public int Tag { get; set; }
        public bool IsBso { get; set; }
        public bool IsCorrection { get; set; }
        public string OperationType { get; set; }
        public string UserInn { get; set; }
        public string KKT_MachineNumber { get; set; }
        public string KktRegNumber { get; set; }
        public string FnNumber { get; set; }
        public int DocNumber { get; set; }
        public int SubjectType { get; set; }
        public DateTime DocDateTime { get; set; }
        public string Operator { get; set; }
        public int DocShiftNumber { get; set; }
        public string DecimalFiscalSign { get; set; }
        public int ReceiptNumber { get; set; }
        public Guid DocRawId { get; set; }
        public Item[] Items { get; set; }
        public int Nds00_TotalSumm { get; set; }
        public int NdsNA_TotalSumm { get; set; }
        public int TotalSumm { get; set; }
        public int CashSumm { get; set; }
        public int ECashSumm { get; set; }
        public int PrepaidSumm { get; set; }
        public int CreditSumm { get; set; }
        public ExtraProperty[] Extra { get; set; }
        public int ProvisionSumm { get; set; }
        public int TaxTotalSumm { get; set; }
        public int Tax10Summ { get; set; }
        public int Tax18Summ { get; set; }
        public int Tax110Summ { get; set; }
        public int Tax118Summ { get; set; }
        public int TaxNaSumm { get; set; }
        public int Tax0Summ { get; set; }
        public string ProductCheckResult { get; set; }
        public int Depth { get; set; }
        public string Buyer_Inn { get; set; }
        public string FnsStatus { get; set; }
        public string FnsError { get; set; }
        public DateTime FnsTime { get; set; }

        public struct ExtraProperty
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public struct Item
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public double Quantity { get; set; }
            public int Total { get; set; }
            public int CalculationMethod { get; set; }
            public string OriginCountryCode { get; set; }
            public string CustomDeclarationNumber { get; set; }
            public string ProductCheckResultDetails { get; set; }
            public string Provider_Inn { get; set; }
        }
    }
}
