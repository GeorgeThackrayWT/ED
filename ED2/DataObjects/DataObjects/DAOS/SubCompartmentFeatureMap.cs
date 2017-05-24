using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("SubCompartmentFeatureMap")]
    public class SubCompartmentFeatureMap : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int FeatureID { get; set; }
        public int SubCompartmentID { get; set; }
        public string MapRef { get; set; }
        public bool Confidential { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public DateTime? LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
