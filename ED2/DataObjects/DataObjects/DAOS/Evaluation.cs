using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Evaluation")]
    public class Evaluation : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int AcquisitionUnitID { get; set; }
        public int EvaluationTypeID { get; set; }
        public int? TypeOfInformationID { get; set; }
        public string Author { get; set; }
        public bool? Confidential { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public string Location { get; set; }
        public string Detail { get; set; }
        public string SuppliedBy { get; set; }
        public double? Cost { get; set; }
        public bool HasDocument { get; set; }
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
