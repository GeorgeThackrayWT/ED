using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Harvesting")]
    public class Harvesting : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int TypeID { get; set; }
        public int ManagementUnitID { get; set; }
        public int SubCompartmentID { get; set; }
        public double WorkAreaInHectares { get; set; }
        public double EstimatedAmount { get; set; }
        public double? ActualAmount { get; set; }
        public string Unit { get; set; }
        public int? ForecastYear { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Comments { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime LMDT { get; set; }
        public int LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
