using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("UserRole")]
    public class UserRole : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int? RegionID { get; set; }
        public int? CountryID { get; set; }
        public DateTime? LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
 
    }
}
