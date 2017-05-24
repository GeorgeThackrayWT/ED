using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Tender")]
    public class Tender : ObservableObject
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Number { get; set; }
        public DateTime? ReturnedByDate { get; set; }
        public int? ReturnedToUser { get; set; }
        public int? OrderID { get; set; }
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
