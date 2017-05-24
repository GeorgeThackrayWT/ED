using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Licence")]
    public class Licence : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int AcquisitionUnitID { get; set; }
        public double? AreaInHectares { get; set; }
        public int? FishingSize { get; set; }
        public int? SizeInID { get; set; }
        public int? LicenceAgreementID { get; set; }
        public int? LicenceTypeID { get; set; }
        public int? FishingTypeID { get; set; }
        public int? InterestLetID { get; set; }
        public string TenantLicensee { get; set; }
        public string Address { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? NoticeOfTerminationID { get; set; }
        public int? CommentsOnTermID { get; set; }
        public bool AgentExists { get; set; }
        public string Agent { get; set; }
        public double? RentOrFee { get; set; }
        public int? LicencePeriodID { get; set; }
        public int? RentReviewID { get; set; }
        public string RentReviewCycle { get; set; }
        public DateTime? RentReviewDate { get; set; }
        public int? ProvisionsNoticeID { get; set; }
        public string Comments { get; set; }
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
