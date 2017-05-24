using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("InternalAuditObservation")]
    public class InternalAuditObservation : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int InternalAuditID { get; set; }
        public string UKWASTrustProcedure { get; set; }
        public string Observation { get; set; }
        public string CorrectiveAction { get; set; }
        public DateTime? DueDate { get; set; }
        public int? ActionByID { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ClosingComments { get; set; }
        public int? GradeID { get; set; }
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
