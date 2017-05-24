using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("ManagementUnitRow")]
    public class ManagementUnitRow : ObservableObject
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public int? RegionId { get; set; }
        public string Region { get; set; }
        public int? ManagerId { get; set; }
        public string Manager { get; set; }
        public int? DeputyId { get; set; }
        public string Deputy { get; set; }
        public int? AUCount { get; set; }
        public bool IsPotSite { get; set; }
        public int ApplicationID { get; set; }
    }
}
