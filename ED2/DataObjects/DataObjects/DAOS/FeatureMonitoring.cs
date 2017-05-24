using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("FeatureMonitoring")]
    public class FeatureMonitoring : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int FeatureID { get; set; }
        public System.DateTime PlannedObservationDate { get; set; }
        public DateTime? ActualObservationDate { get; set; }
        public DateTime? DeadlineActionDate { get; set; }
        public DateTime? ActualActionDate { get; set; }
        public string AttributeToBeMeasured { get; set; }
        public string PredictionShortTermObjective { get; set; }
        public string PlannedObservation { get; set; }
        public string ActualObservation { get; set; }
        public string SuggestionsAndActions { get; set; }
        public int? LowerLimit { get; set; }
        public int? UpperLimit { get; set; }
        public string Method { get; set; }
        public int? TargetValue { get; set; }
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
