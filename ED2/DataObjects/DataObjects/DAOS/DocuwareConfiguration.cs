using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("DocuwareConfiguration")]
    public class DocuwareConfiguration : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int CabinetID { get; set; }
        public string ServerName { get; set; }
        public string TargetDirectory { get; set; }
        public string PathExtension { get; set; }
        public string IntegrationIdentifier { get; set; }
        public int LoginTypeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginKey { get; set; }
        public string LoginToken { get; set; }
        public bool HttpSecure { get; set; }
        public bool Enabled { get; set; }
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
