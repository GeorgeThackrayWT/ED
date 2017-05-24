using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("EmailTask")]
    public class EmailTask : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int ManagementUnitID { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public int? SenderID { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? SentDate { get; set; }
        public System.DateTime DeadlineDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? ActionDeadlineDate { get; set; }
        public DateTime? ActionCompletedDate { get; set; }
        public string RequestComments { get; set; }
        public string ClosingComments { get; set; }
        public string SuggestionsOrActions { get; set; }
        public int DocumentID { get; set; }
        public bool NotifyOnComplete { get; set; }
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
