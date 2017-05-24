using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Grant")]
    public class Grant : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ManagementPlanID { get; set; }
        public int GrantBodyID { get; set; }
        public int SchemeID { get; set; }
        public string Reference { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Comments { get; set; }
        public bool IsMainContract { get; set; }
        public bool IsClumpedContract { get; set; }
        public int? ClumpedWithID { get; set; }
        public bool Completed { get; set; }
        public int? CompletedByID { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool Authorised { get; set; }
        public int? AuthorisedByID { get; set; }
        public DateTime? DateAuthorised { get; set; }
        public bool Archived { get; set; }
        public int? ArchivedByID { get; set; }
        public DateTime? DateArchived { get; set; }
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
