using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("ExternalLink")]
    public class ExternalLink : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int TypeID { get; set; }
        public int? ManagementUnitID { get; set; }
        public string URL { get; set; }
    }
}
