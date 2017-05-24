using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;

namespace DataObjects.DAOS
{
    [Table("TaxCode")]
    public class TaxCode : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Section { get; set; }
        public string VATCode { get; set; }
        public double TaxRate { get; set; }
        public double VATRate { get; set; }
        public string Description { get; set; }
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
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Expenditure> Expenditures { get; set; }
        public virtual ICollection<ExpenditureProduct> ExpenditureProducts { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<IncomeProduct> IncomeProducts { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<VATRateLock> VATRateLocks { get; set; }
        public virtual ICollection<VATRateLock> VATRateLocks1 { get; set; }
    }
}
