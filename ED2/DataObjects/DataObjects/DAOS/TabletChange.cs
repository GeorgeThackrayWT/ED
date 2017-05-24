using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("TabletChange")]
    public class TabletChange : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public System.Guid TransactionID { get; set; }
        public int ItemID { get; set; }
        public int RecordID { get; set; }
        public int FieldID { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int ResultCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
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
