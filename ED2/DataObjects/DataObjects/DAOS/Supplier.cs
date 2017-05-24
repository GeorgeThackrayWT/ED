using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("Supplier")]
    public class Supplier : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Suppcat { get; set; }
        public string Description { get; set; }
        public string Suppgrp { get; set; }
        public string Address { get; set; }
        public string PostalNo { get; set; }
        public string Town { get; set; }
        public string Code { get; set; }
        public string County { get; set; }
        public string Telephone { get; set; }
        public string Telefax { get; set; }
        public string Telex { get; set; }
        public string Mobile { get; set; }
        public string Pager { get; set; }
        public string Home { get; set; }
        public string Assistant { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string Address_type { get; set; }
        public int TaxCodeID { get; set; }
        public bool IsTreeSupplier { get; set; }
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
