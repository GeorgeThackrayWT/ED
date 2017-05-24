using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Configuration")]
    public class Configuration : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public System.DateTime CurrentYear { get; set; }
        public int PurchaseOrderMajorNumber { get; set; }
        public int SalesOrderMajorNumber { get; set; }
        public int FirstExpAccountCode { get; set; }
        public string OrdersDropDirectory { get; set; }
        public string PurchaseFilename { get; set; }
        public string SalesFilename { get; set; }
        public bool BudgetLock { get; set; }
        public bool FutureBudgetLock { get; set; }
        public string ChalaraWorkOrderCode { get; set; }
        public string VATGuideURL { get; set; }
        public bool DisablePO { get; set; }
        public bool DisableSO { get; set; }
        public string DisablePOMessage { get; set; }
        public string DisableSOMessage { get; set; }
        public string ReportServer { get; set; }
        public string ReportPath { get; set; }
        public string ReportDropDirectory { get; set; }
        public int ReportTimeout { get; set; }
        public DateTime? TasksCutOffDate { get; set; }
        public DateTime? SafetyTasksCutOffDate { get; set; }
        public DateTime? TreePlantingTasksCutOffDate { get; set; }
        public string PEResNo { get; set; }
        public string NEDResNo { get; set; }
        public string AWRResNo { get; set; }
        public DateTime? LastAppliedAt { get; set; }
        public bool Deleted { get; set; }
        public DateTime? LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
