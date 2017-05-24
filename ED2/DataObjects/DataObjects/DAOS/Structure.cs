
using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("Structure")]
    public class Structure : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int AcquisitionUnitID { get; set; }
        public int? StructureTypeID { get; set; }
        public string Description { get; set; }
        public int? StructureConditionID { get; set; }
        public double? RebuildCost { get; set; }
        public bool Responsibility { get; set; }
        public string ResponsibilityDescr { get; set; }
        public double? AnnualMaintenanceCosts { get; set; }
        public DateTime? LastInspectionDate { get; set; }
        public DateTime? NextInspectionDate { get; set; }
        public string ReportAuthor { get; set; }
        public string BriefReportSummary { get; set; }
        public bool Completed { get; set; }
        public bool ExternalSurveyorRequired { get; set; }
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
