using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("MetadataField")]
    public class MetadataField : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int RecordID { get; set; }
        public string FieldName { get; set; }
        public string FieldAlias { get; set; }
        public string SysFieldName { get; set; }
        public string FieldTypeRef { get; set; }
        public int? RecordRefID { get; set; }
        public bool IsKey { get; set; }
        public bool IsRequired { get; set; }
        public bool ReadOnly { get; set; }
        public int MaxLength { get; set; }
        public string Permissions { get; set; }
        public bool Sync { get; set; }
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
