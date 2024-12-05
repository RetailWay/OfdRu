using System;

namespace RetailWay.Integration.OfdRu.DataModels
{
    public struct Report
    {
        public Guid Id { get; set; }
        public DateTime Open_CDateUtc { get; set; }
        public DateTime Close_CDateUtc { get; set; }
        public string UserInn { get; set; }
        public string KktRegNumber { get; set; }
        public string FnNumber { get; set; }
        public int ShiftNumber { get; set; }
        public string Operator { get; set; }
        public int Open_DocNumber { get; set; }
        public DateTime Open_DocDateTime { get; set; }
        public Guid Open_DocRawId { get; set; }
        public int Close_DocNumber { get; set; }
        public DateTime Close_DocDateTime { get; set; }
        public Guid Close_DocRawId { get; set; }
        public int ShiftDocsCount { get; set; }
        public int IncomeSumm { get; set; }
        public int IncomeCashSumm { get; set; }
        public int IncomeECashSumm { get; set; }
        public int IncomeCount { get; set; }
        public int AdvanceSumm { get; set; }
        public int CreditSumm { get; set; }
        public int ExchangeSumm { get; set; }
        public int RefundIncomeSumm { get; set; }
        public int RefundIncomeCashSumm { get; set; }
        public int RefundIncomeCount { get; set; }
        public int ExpenseSumm { get; set; }
        public int ExpenseCount { get; set; }
        public int RefundExpenseSumm { get; set; }
        public int RefundExpenseCount { get; set; }
        public int RefundAdvanceSumm { get; set; }
        public int RefundCreditSumm { get; set; }
        public int RefundExchangeSumm { get; set; }
        public int TaxTotalSumm { get; set; }
        public int Tax10Summ { get; set; }
        public int Tax18Summ { get; set; }
        public int Tax110Summ { get; set; }
        public int Tax118Summ { get; set; }
        public int TaxNaSumm { get; set; }
        public int Tax0Summ { get; set; }
    }
}
