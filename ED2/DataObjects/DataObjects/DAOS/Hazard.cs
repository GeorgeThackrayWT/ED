using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Hazard")]
    public class Hazard : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ManagementUnitID { get; set; }
        public int? TypeID { get; set; }
        public int? OwnershipID { get; set; }
        public int? LocationId { get; set; }
        public string Description { get; set; }
        public string MapReference { get; set; }
        public bool AppliesToEntireSite { get; set; }
        public bool StructureReportRequired { get; set; }
        public string GISDataSource { get; set; }
        public int? GISUpdatedByID { get; set; }
        public DateTime? GISUpdatedDate { get; set; }
        public double? Easting { get; set; }
        public double? Northing { get; set; }
        public double? SiteCentreEasting { get; set; }
        public double? SiteCentreNorthing { get; set; }
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
