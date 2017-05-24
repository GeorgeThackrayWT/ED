using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("ManagementUnitAttribute")]
    public class ManagementUnitAttribute : ObservableObject
    {
        public int AttributeID { get; set; }
        public int ManagementUnitID { get; set; }
        public DateTime? LMDT { get; set; }
        public int? LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        public int? DLUID { get; set; }
    }
}
