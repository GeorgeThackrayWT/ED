using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("HazardAction")]
    public class HazardAction : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int HazardID { get; set; }
        public string Description { get; set; }
        public int? SeverityProbabilityOfHarmID { get; set; }
        public string FurtherAction { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? FollowOnActionID { get; set; }
        public DateTime? FollowOnDeadline { get; set; }
        public DateTime? FollowOnComplete { get; set; }
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
