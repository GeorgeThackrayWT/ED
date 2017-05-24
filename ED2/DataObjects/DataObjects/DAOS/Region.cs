using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Region")]
    public class Region : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DocuwareName { get; set; }
        public bool ForecastApproved { get; set; }
        public DateTime? DateForecastApproved { get; set; }
        public int CountryID { get; set; }
        public string ResNo { get; set; }
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


        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ManagementUnit> ManagementUnits { get; set; }
    }
}
