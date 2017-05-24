using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("TreePlanting")]
    public class TreePlanting : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int SubCompartmentID { get; set; }
        public DateTime? PlantingDate { get; set; }
        public bool Completed { get; set; }
        public int PlantingTypeID { get; set; }
        public int PlantedByID { get; set; }
        public bool SuitableToBeSold { get; set; }
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