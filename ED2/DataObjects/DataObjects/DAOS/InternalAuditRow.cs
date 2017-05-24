using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("InternalAuditRow")]
    public class InternalAuditRow : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime? AuditDate { get; set; }
        public string RegionName { get; set; }
        public int? ManagerID { get; set; }
        public string ManagerName { get; set; }
        public int? FirstAuditorID { get; set; }
        public string FirstAuditor { get; set; }
        public int? SecondAuditorID { get; set; }
        public string SecondAuditor { get; set; }
        public int? CertifiedByID { get; set; }
        public string CertifiedBy { get; set; }
        public DateTime? CertifyDate { get; set; }
        public int? AuthorisedByID { get; set; }
        public string AuthorisedBy { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime LMDT { get; set; }
        public int LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
