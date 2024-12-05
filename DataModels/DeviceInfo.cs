using System;

namespace RetailWay.Integration.OfdRu.DataModels
{
    public struct DeviceInfo
    {
        public Guid Id { get; set; }
        public string KktRegId { get; set; }
        public string KktName { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string FnNumber { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime LastDocOnKktDateTime { get; set; }
        public DateTime LastDocOnOfdDateTimeUtc { get; set; }
        public DateTime FirstDocumentDate { get; set; }
        public string FiscalAddress { get; set; }
        public string FiscalPlace { get; set; }
        public string Path { get; set; }
        public string KktModel { get; set; }
        public DateTime FnEndDate { get; set; }
    }
}
