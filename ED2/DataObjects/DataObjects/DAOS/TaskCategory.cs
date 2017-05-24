using System;
using System.Collections.Generic;
using System.Diagnostics;
using MvvmHelpers;
using SQLite.Net.Attributes;
using SQLiteNetExtensionsAsync.Extensions;
using WTSqLExt.Attributes;

namespace DataObjects.DAOS
{
    [Table("TaskCategory")]
    public class TaskCategory : WtDataObject<TaskCategory>
    {
        public TaskCategory()
        {
            Debug.WriteLine("TaskCategory constructor");
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
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

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Task> Tasks { get; set; }
    }
}
