using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("InternalAudit")]
    public class InternalAudit : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime? AuditDate { get; set; }
        public int? SiteManagerID { get; set; }
        public string SiteManager { get; set; }
        public int? FirstAuditorID { get; set; }
        public string FirstAuditor { get; set; }
        public int? SecondAuditorID { get; set; }
        public string SecondAuditor { get; set; }
        public string GeneralSummary { get; set; }
        public int? CertifiedByID { get; set; }
        public DateTime? CertifyDate { get; set; }
        public int? AuthorisedByID { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public bool Published { get; set; }
        public int? PublishedByID { get; set; }
        public DateTime? PublishingDate { get; set; }
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
