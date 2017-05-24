using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("ThirdPartyRight")]
    public class ThirdPartyRight : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int AcquisitionUnitID { get; set; }
        public int? ServiceID { get; set; }
        public int? TypeID { get; set; }
        public int? AgreementID { get; set; }
        public string AgreementWith { get; set; }
        public DateTime? CurrentPaymentDate { get; set; }
        public double? CurrentAmount { get; set; }
        public DateTime? CurrentReceivedDate { get; set; }
        public DateTime? ForecastPaymentDate { get; set; }
        public double? ForecastAmount { get; set; }
        public DateTime? ForecastReceivedDate { get; set; }
        public DateTime? InitialEnquiryDate { get; set; }
        public DateTime? ResponseReceivedDate { get; set; }
        public DateTime? ResponseReceivedTargetDate { get; set; }
        public bool ResponseResult { get; set; }
        public DateTime? MTMApprovalDate { get; set; }
        public DateTime? MTMApprovalTargetDate { get; set; }
        public DateTime? SouthernElectricDate { get; set; }
        public DateTime? SouthernElectricTargetDate { get; set; }
        public DateTime? WTDate { get; set; }
        public DateTime? WTTargetDate { get; set; }
        public DateTime? AgreementFromDate { get; set; }
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
