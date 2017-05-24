using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("ReportBinary")]
    public class ReportBinary : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte[] Data { get; set; }
        public string Warnings { get; set; }
        public string SessionId { get; set; }
        public string ContentType { get; set; }
        public string HistoryID { get; set; }
        public string Encoding { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }
        public string Size { get; set; }
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
