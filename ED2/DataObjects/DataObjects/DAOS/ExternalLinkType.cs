using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;


namespace DataObjects.DAOS
{
    [Table("ExternalLinkType")]
    public class ExternalLinkType : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
    }
}
