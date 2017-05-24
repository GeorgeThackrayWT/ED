using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using SQLiteNetExtensionsAsync.Extensions;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("User")]
    public class User : WtDataObject<User>
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string DisplayName { get; set; }
        public Nullable<long> SecurityToken { get; set; }
        public int? RegionID { get; set; }
        public int? OfficeLocation { get; set; }
        public bool FirstRun { get; set; }
        public bool LoggedOn { get; set; }
        public string ComputerName { get; set; }
        public string Email { get; set; }
        public System.DateTime LNRDT { get; set; }
        public int? AuthorisationLevelID { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public System.DateTime LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
       
    }
}
