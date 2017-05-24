using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Expenditure")]
    public class Expenditure : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Kind { get; set; }
        public Nullable<System.Guid> GroupGuid { get; set; }
        public int ManagementUnitID { get; set; }
        public bool Project { get; set; }
        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }
        public int AimID { get; set; }
        public string Notes { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public double Budget { get; set; }
        public double? Ordered { get; set; }
        public double? Forecast { get; set; }
        public double LastMonthForecast { get; set; }
        public double? Actual { get; set; }
        public double? TenderPrice { get; set; }
        public bool? GRN { get; set; }
        public string CptNo { get; set; }
        public bool EMC { get; set; }
        public bool PesticideRecord { get; set; }
        public string EMCSpec { get; set; }
        public bool WSP { get; set; }
        public bool DTP { get; set; }
        public bool PE { get; set; }
        public bool Pipeline { get; set; }
        public int FundingStatusID { get; set; }
        public string PONo { get; set; }
        public DateTime? PODate { get; set; }
        public int? TenderID { get; set; }
        public int? TaxCodeID { get; set; }
        public int AccountingYear { get; set; }
        public bool RPI { get; set; }
        public bool Confidential { get; set; }
        public bool OpsGrantAided { get; set; }
        public bool Completed { get; set; }
        public bool Chalara { get; set; }
        public bool VolunteerWork { get; set; }
        public bool Cancelled { get; set; }
        public bool NoSync { get; set; }
        public int? NumberOfTrees { get; set; }
        public int? NumberOfTreesOrigin { get; set; }
        public double? CostPerTree { get; set; }
        public int? TreeSupplierID { get; set; }
        public int? WCExpenditureID { get; set; }
        public int? ProvenanceZoneID { get; set; }
        public int? PlantTypeID { get; set; }
        public int? GrownMethodID { get; set; }
        public double? Size_cm { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public System.DateTime LMDT { get; set; }
        public int LMUID { get; set; }
        public DateTime? ULMDT { get; set; }
        public int? ULMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
