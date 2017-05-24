using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Pesticide")]
    public class Pesticide : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ContractorName { get; set; }
        public string ContractorCode { get; set; }
        public int ManagementUnitID { get; set; }
        public int? AcquisitionUnitID { get; set; }
        public int? ExpenditureID { get; set; }
        public string OldPONumber { get; set; }
        public string SurplusDisposed { get; set; }
        public string Comments { get; set; }
        public int? SiteClassificationID { get; set; }
        public int? ReasonForUseID { get; set; }
        public int? TargetSpeciesID { get; set; }
        public int? ProductID { get; set; }
        public string ProductDescr { get; set; }
        public double? NetAreaTreatedHa { get; set; }
        public double ConcentrateQuantity { get; set; }
        public double ApplicationRate { get; set; }
        public int? ApplicationUnitID { get; set; }
        public string LocationInSite { get; set; }
        public int? ActiveIngredientID { get; set; }
        public string OtherIngredient { get; set; }
        public int? ApplicationTypeID { get; set; }
        public int? ApplicationMethodID { get; set; }
        public string WeatherConditions { get; set; }
        public bool WholeSite { get; set; }
        public bool Archived { get; set; }
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
