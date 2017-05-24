using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("ManagementPlan")]
    public class ManagementPlan : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte[] PDFFile { get; set; }
        public byte[] WoodBoardPDFFile { get; set; }
        public byte[] WoodBoardJPGFile { get; set; }
        public bool UnderConsultation { get; set; }
        public DateTime? ConsultationEndDate { get; set; }
        public DateTime? ReviewDeadline { get; set; }
        public bool UnderReview { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public bool Approved { get; set; }
        public int? ApprovedByID { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? LastExported { get; set; }
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
