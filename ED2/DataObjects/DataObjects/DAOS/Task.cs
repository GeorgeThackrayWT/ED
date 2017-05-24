using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using MvvmHelpers;
using SQLite.Net.Attributes;
using SQLiteNetExtensionsAsync.Extensions;
using WTSqLExt.Attributes;
using WTSqLExtAsync.Extensions;
using WTSqLExt.Extensions;


namespace DataObjects.DAOS
{


    [Table("Task")]
    public class Task : WtDataObject<Task>
    {
        //public Task()
        //{
        //    Debug.WriteLine("Task constructor");
        //}

      

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(ManagementUnit))]
        public int? ManagementUnitID { get; set; }

        [ForeignKey(typeof(AcquisitionUnit))]
        public int? AcquisitionUnitID { get; set; }

        public int SrcRecordID { get; set; }

        public string SrcFieldName { get; set; }
     
        public int? Src2RecordID { get; set; }
    
        public string Src2FieldName { get; set; }
        
        public System.DateTime DeadlineDate { get; set; }
      

        public DateTime? CompletedDate { get; set; }


        [ForeignKey(typeof(TaskCategory))]
        public int CategoryID { get; set; }
     
        public string Notes { get; set; }

        public string Label { get; set; }

        public double? Amount { get; set; }

        public bool Deleted { get; set; }

        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
   
        public System.DateTime LMDT { get; set; }       
        public DateTime? CRDT { get; set; }        
        public DateTime? DLDT { get; set; }

        [ForeignKey(typeof(User))]
        public int? DLUID { get; set; }
        [ForeignKey(typeof(User))]
        public int? LMUID { get; set; }
        [ForeignKey(typeof(User))]
        public int? CRUID { get; set; }

        [ManyToOne]      
        public User DLUser { get; set; }

        [ManyToOne]      
        public User LMUser { get; set; }

        [ManyToOne]      
        public User CRUser { get; set; }

        [ManyToOne]      
        public TaskCategory TaskCategory { get; set; }

        [ManyToOne]
        public ManagementUnit ManagementUnit { get; set; }


        [ManyToOne]
        public AcquisitionUnit AcquisitionUnit { get; set; }

    }
}

