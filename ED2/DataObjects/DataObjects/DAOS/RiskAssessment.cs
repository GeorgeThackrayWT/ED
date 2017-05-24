using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("RiskAssessment")]
    public class RiskAssessment : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int? CompletedByWoodlandOfficerID { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool Authorised { get; set; }
        public DateTime? DateAuthorised { get; set; }
        public int? AuthorisedByRegionalManagerID { get; set; }
        public int? FireAssessmentID { get; set; }
        public int? BiosecurityZoneID { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string PersonalIssues { get; set; }
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
