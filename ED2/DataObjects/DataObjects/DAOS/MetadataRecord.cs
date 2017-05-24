using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("MetadataRecord")]
    public class MetadataRecord : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string RecordName { get; set; }
        public string RecordAlias { get; set; }
        public string SysRecordName { get; set; }
        public int? ParentRecordID { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLookup { get; set; }
        public bool Sync { get; set; }
        public bool SyncAll { get; set; }
        public bool SyncDeleted { get; set; }
        public bool SyncOut { get; set; }
        public string SQLQuery { get; set; }
        public int? Order { get; set; }
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
