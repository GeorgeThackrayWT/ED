using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("ReportQueue")]
    public class ReportQueue : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int? BinaryID { get; set; }
        public string ReportName { get; set; }
        public string FileName { get; set; }
        public string Mode { get; set; }
        public string SiteIDs { get; set; }
        public int ApplicationID { get; set; }
        public int ReportFormat { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string CustomParameters { get; set; }
        public bool Generated { get; set; }
        public string GenErrorMessage { get; set; }
        public string GenErrorDetails { get; set; }
        public bool Submitted { get; set; }
        public string SendErrorMessage { get; set; }
        public string SendErrorDetails { get; set; }
        public DateTime? ScheduledAt { get; set; }
        public string ToList { get; set; }
        public string CcList { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public System.DateTime LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
