using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("SubCompartment")]
    public class SubCompartment : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ManagementUnitID { get; set; }
        public int Compartment { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double AreaInHectares { get; set; }
        public int? PAWSStatus { get; set; }
        public bool IsWoodland { get; set; }
        public bool IsWoodlandCreation { get; set; }
        public bool IsOtherHabitat { get; set; }
        public int? Year { get; set; }
        public int? MainSpeciesID { get; set; }
        public int? SecondSpeciesID { get; set; }
        public int? ManagementRegimeID { get; set; }
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
