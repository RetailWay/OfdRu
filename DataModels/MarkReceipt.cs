using System;

namespace RetailWay.Integration.OfdRu.DataModels
{
    public struct MarkReceipt
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

        public struct Codes
        {
            public string Code_EAN_8 { get; set; }
            public string Code_EAN_13 { get; set; }
            public string Code_ITF_14 { get; set; }
            public string Code_GS_1 { get; set; }
            public string Code_GS_1M { get; set; }
            public string Code_KMK { get; set; }
            public string Code_MI { get; set; }
            public string Code_F_1 { get; set; }
            public string Code_F_6 { get; set; }
        }

        public struct Item
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public double Quantity { get; set; }
            public int Total { get; set; }
            public int CalculationMethod { get; set; }
            public int SubjectType { get; set; }
            public int NDS_Rate { get; set; }
            public string UnitOfMeasure { get; set; }
            public string Provider_Inn { get; set; }
            public string OriginCountryCode { get; set; }
            public string CustomDeclarationNumber { get; set; }
            public int ProductCheckResultDetails { get; set; }
            public int ProductUnitOfMeasure { get; set; }
            public Codes ProductCode { get; set; }
        }
    }
}
