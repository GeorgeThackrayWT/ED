using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("PublicInfo")]
    public class PublicInfo : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ManagementUnitID { get; set; }
        public string ExtendedDescription { get; set; }
        public string Setting { get; set; }
        public string History { get; set; }
        public string Wildlife { get; set; }
        public string TreesAndPlants { get; set; }
        public string AccessWalks { get; set; }
        public string GettingThere { get; set; }
        public string NearestAmenities { get; set; }
        public string Folklore { get; set; }
        public string OriginOfName { get; set; }
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
