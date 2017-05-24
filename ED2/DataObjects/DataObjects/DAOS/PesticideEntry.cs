using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("PesticideEntry")]
    public class PesticideEntry : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int PesticideID { get; set; }
        public DateTime? Date { get; set; }
        public string Operator { get; set; }
        public double? HoursWorked { get; set; }
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
