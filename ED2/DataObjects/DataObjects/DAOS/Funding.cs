using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Funding")]
    public class Funding : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int AcquisitionUnitID { get; set; }
        public int? TypeID { get; set; }
        public string DonorName { get; set; }
        public double? Amount { get; set; }
        public double? GiftAidOfferAmount { get; set; }
        public DateTime? OfferedDate { get; set; }
        public DateTime? ConditionsApprovedDate { get; set; }
        public DateTime? FundingConfirmedDate { get; set; }
        public DateTime? ClaimedDate { get; set; }
        public DateTime? PaymentReceivedDate { get; set; }
        public bool GrantConditionsExist { get; set; }
        public string GrantConditionsDescr { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public System.DateTime LMDT { get; set; }
        public int LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
