using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Farming")]
    public class Farming : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string SBIBRNCRN { get; set; }
        public string CPHNo { get; set; }
        public int? VendorNo { get; set; }
        public bool SFPS { get; set; }
        public bool ELS { get; set; }
        public bool HLS { get; set; }
        public bool Registered { get; set; }
        public bool LFA { get; set; }
        public bool SRDP { get; set; }
        public bool ARP { get; set; }
        public bool CSS { get; set; }
        public bool GlastirAWE { get; set; }
        public bool GlastirTE { get; set; }
        public DateTime? ELSDate { get; set; }
        public DateTime? HLSDate { get; set; }
        public DateTime? CSSDate { get; set; }
        public DateTime? GlastirAWEDate { get; set; }
        public DateTime? GlastirTEDate { get; set; }
        public string ELSRefNo { get; set; }
        public string HLSRefNo { get; set; }
        public string CSSRefNo { get; set; }
        public string GlastirAWERefNo { get; set; }
        public string GlastirTERefNo { get; set; }
        public bool WTFarmingLtd { get; set; }
        public bool FWPS { get; set; }
        public bool ILP { get; set; }
        public bool GlastirWCP { get; set; }
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
