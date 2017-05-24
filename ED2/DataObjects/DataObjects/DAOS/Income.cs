using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Income")]
    public class Income : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
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
        public double? ClmdInvd { get; set; }
        public double? Forecast { get; set; }
        public double LastMonthForecast { get; set; }
        public double? Actual { get; set; }
        public double? NetIncome { get; set; }
        public bool? Received { get; set; }
        public string GrantScheme { get; set; }
        public string GrantReference { get; set; }
        public bool PE { get; set; }
        public bool Pipeline { get; set; }
        public string SONo { get; set; }
        public DateTime? SODate { get; set; }
        public int? OrderID { get; set; }
        public int? TaxCodeID { get; set; }
        public int? GrantID { get; set; }
        public bool Confidential { get; set; }
        public bool Completed { get; set; }
        public bool Cancelled { get; set; }
        public bool NoSync { get; set; }
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
