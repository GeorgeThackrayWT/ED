using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("LookupTable")]
    public class LookupTable : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string SQLTable { get; set; }
        public string Description { get; set; }
        public string Column1Name { get; set; }
        public string Column1Description { get; set; }
        public int? Column1LookupID { get; set; }
        public string Column2Name { get; set; }
        public string Column2Description { get; set; }
        public int? Column2LookupID { get; set; }
        public string Column3Name { get; set; }
        public string Column3Description { get; set; }
        public int? Column3LookupID { get; set; }
        public string Column4Name { get; set; }
        public string Column4Description { get; set; }
        public int? Column4LookupID { get; set; }
        public string Column5Name { get; set; }
        public string Column5Description { get; set; }
        public int? Column5LookupID { get; set; }
        public string Column6Name { get; set; }
        public string Column6Description { get; set; }
        public int? Column6LookupID { get; set; }
        public string Column7Name { get; set; }
        public string Column7Description { get; set; }
        public int? Column7LookupID { get; set; }
        public string Column8Name { get; set; }
        public string Column8Description { get; set; }
        public int? Column8LookupID { get; set; }
    }
}
