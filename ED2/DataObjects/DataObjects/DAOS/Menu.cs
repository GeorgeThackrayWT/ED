using SQLite.Net.Attributes;
using SQLiteNetExtensionsAsync.Extensions;
using WTSqLExt.Attributes;


namespace DataObjects.DAOS
{

    [Table("Menu")]
    public class Menu : WtDataObject<Menu>
    { 

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Menu))]
        public int? ParentMenuId { get; set; }
 
        public string Caption { get; set; }

        public string Destination { get; set; }

    }
}

