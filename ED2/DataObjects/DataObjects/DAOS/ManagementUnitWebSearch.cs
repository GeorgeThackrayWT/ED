using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("ManagementUnitWebSearch")]
    public class ManagementUnitWebSearch : ObservableObject
    {
        public int? ID { get; set; }
        public double? AreaInHectares { get; set; }
        public Nullable<long> DirectoryInformation { get; set; }
        public Nullable<long> CombinedDirectoryInformation { get; set; }
        public string HistoricName { get; set; }
        public string Designation { get; set; }
        public string AcquisitionName { get; set; }
        public string Region { get; set; }
        public int ManagementUnitWebSearchID { get; set; }
        public DateTime? LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
