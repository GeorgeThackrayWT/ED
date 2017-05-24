using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("TreePlantingDetail")]
    public class TreePlantingDetail : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int TreePlantingID { get; set; }
        public int TerrainTypeID { get; set; }
        public int AccessTypeID { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public double? PlantingArea { get; set; }
        public double PlantedArea { get; set; }
        public int? TreesToPlant { get; set; }
        public int TreesPlanted { get; set; }
        public int TreesAllocated { get; set; }
        public string Comments { get; set; }
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
