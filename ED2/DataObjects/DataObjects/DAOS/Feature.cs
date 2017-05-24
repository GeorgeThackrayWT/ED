using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Feature")]
    public class Feature : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ManagementUnitID { get; set; }
        public string Reference { get; set; }
        public string OtherTypeDescription { get; set; }
        public int? TypeID { get; set; }
        public int? AimID { get; set; }
        public string Description { get; set; }
        public bool Confidential { get; set; }
        public string BiodiversityActionPlans { get; set; }
        public string ConstraintsAndOpportunities { get; set; }
        public string ShortTermObjective { get; set; }
        public string LongTermObjective { get; set; }
        public string OtherCostedHabitatActionPlans { get; set; }
        public bool? AppliesToEntireSite { get; set; }
        public string Significance { get; set; }
        public string FactorsCausingChange { get; set; }
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
