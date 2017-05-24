using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("AcquisitionUnitRow")]
    public class AcquisitionUnitRow : ObservableObject
    {
        public int WoodId { get; set; }
        public string WoodName { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public bool IsPotSite { get; set; }
        public int WoodlandOfficerID { get; set; }
        public string WoodlandOfficer { get; set; }
        public int? AcquisitionOfficerID { get; set; }
        public string AcquisitionOfficer { get; set; }
        public long DirectoryInformation { get; set; }
        public int TypeID { get; set; }
        public string Type { get; set; }
    }
}
