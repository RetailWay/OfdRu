using System;

namespace RetailWay.Integration.OfdRu.DataModels
{
    public struct ReceiptDetail
    {
        public int Tag { get; set; }
        public string User { get; set; }
        public string UserInn { get; set; }
        public int Number { get; set; }
        public DateTime DateTime { get; set; }
        public int ShiftNumber { get; set; }
        public string OperationType { get; set; }
        public int TaxationType { get; set; }
        public string Operator { get; set; }
        public string KKT_RegNumber { get; set; }
        public string FN_FactoryNumber { get; set; }
        public Item[] Items { get; set; }
        public int Nds18_TotalSumm { get; set; }
        public int Nds10_TotalSumm { get; set; }
        public int Nds00_TotalSumm { get; set; }
        public int NdsNA_TotalSumm { get; set; }
        public int Nds18_CalculatedTotalSumm { get; set; }
        public int Nds10_CalculatedTotalSumm { get; set; }
        public string[] ProductNomenclature { get; set; }
        public int NDS_PieceSumm { get; set; }
        public string ProductAdditionalRequisite { get; set; }
        public string RetailPlaceAddress { get; set; }
        public string Buyer_Address { get; set; }
        public string Sender_Address { get; set; }
        public string PaymentAgent_Phone { get; set; }
        public string MoneyOperator_Phone { get; set; }
        public string BankAgent_Phone { get; set; }
        public string BankAgent_Operation { get; set; }
        public string MoneyOperator_Name { get; set; }
        public string MoneyOperator_Address { get; set; }
        public string MoneyOperator_INN { get; set; }
        public int Amount_Total { get; set; }
        public int Amount_Cash { get; set; }
        public int Amount_ECash { get; set; }
        public int Document_Number { get; set; }
        public string FiscalSign { get; set; }
        public string DecimalFiscalSign { get; set; }
        public string KKT_MachineNumber { get; set; }
        public int InternetSign { get; set; }
        public ExtraProperty[] Extra { get; set; }
        public int Format_Version { get; set; }
        public int Amount_Advance { get; set; }
        public int Amount_Loan { get; set; }
        public int Amount_Granting { get; set; }
        public string TaxAuthority_Site { get; set; }
        public string Calculation_Place { get; set; }
        public string Supplier_Phone { get; set; }
        public string Operator_INN { get; set; }
        public string PaymentAgentMode { get; set; }
        public string ReceiptAdditionalRequisite { get; set; }
        public int ProductCheckResult { get; set; }
        public int ProductUnitOfMeasure { get; set; }
        public Codes ProductCode { get; set; }
        public int? Correction_Type { get; set; }
        public CorrectionData? Correction { get; set; }

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
            public int SubjectType { get; set; }
            public int NDS_Rate { get; set; }
            public int NDS_Summ { get; set; }
            public string UnitOfMeasure { get; set; }
            public string OriginCountryCode { get; set; }
            public string CustomDeclarationNumber { get; set; }
            public int ProductCheckResultDetails { get; set; }
            public int ProductUnitOfMeasure { get; set; }
        }

        public struct CorrectionData
        {
            public DateTime Date { get; set; }
            public string DocNumber { get; set; }
        }
    }
}
