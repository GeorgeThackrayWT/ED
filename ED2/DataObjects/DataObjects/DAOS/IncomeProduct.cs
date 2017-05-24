using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("IncomeProduct")]
    public class IncomeProduct : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int AimID { get; set; }
        public int AccountCode { get; set; }
        public string Account { get; set; }
        public int WTActivityCode { get; set; }
        public string WTActivity { get; set; }
        public int? TaxCodeID { get; set; }
        public int ApplicationID { get; set; }
        public bool Locked { get; set; }
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
