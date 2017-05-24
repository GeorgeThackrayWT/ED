using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("TaskRow")]
    public class TaskRow : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int? ManagementUnitID { get; set; }
        public string ManagementUnitName { get; set; }
        public string RegionName { get; set; }
        public string ManagerName { get; set; }
        public int? AcquisitionUnitID { get; set; }
        public string AcquisitionUnitName { get; set; }
        public int SrcRecordID { get; set; }
        public string SrcFieldName { get; set; }
        public int? Src2RecordID { get; set; }
        public string Src2FieldName { get; set; }
        public System.DateTime DeadlineDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Notes { get; set; }
        public string Label { get; set; }
        public double? Amount { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
