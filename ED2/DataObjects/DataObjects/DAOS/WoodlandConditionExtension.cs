using System;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("WoodlandConditionExtension")]
    public class WoodlandConditionExtension : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int FeatureMonitoringID { get; set; }
        public double AreaHa { get; set; }
        public double AreaAWHa { get; set; }
        public string Surveyor { get; set; }
        public double ChangeInAreaSinceLastSurveyHa { get; set; }
        public double ChangeInAreaAWSinceLastSurveyHa { get; set; }
        public string ConclusionsAndRecommendations { get; set; }
        public bool OverallDesirable { get; set; }
        public bool OverallAchievable { get; set; }
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
