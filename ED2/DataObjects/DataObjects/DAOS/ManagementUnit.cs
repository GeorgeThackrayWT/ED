using System;
using WTSqLExt.Attributes;
using SQLite.Net.Attributes;
using MvvmHelpers;
using System.Collections.Generic;
using DataObjects.DAOS;
using SQLiteNetExtensionsAsync.Extensions;
//using SQLite;


namespace DataObjects.DAOS
{
    [Table("ManagementUnit")]
    public class ManagementUnit : WtDataObject<ManagementUnit>
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        //[ForeignKey(typeof(N))]
        public int NavisionID { get; set; }

        [ForeignKey(typeof(User))]
        public int WoodlandOfficerID { get; set; }

        [ForeignKey(typeof(User))]
        public int? PreviousOfficerID { get; set; }

        [ForeignKey(typeof(User))]
        public int? DeputyID { get; set; }


        public string Name { get; set; }
        public string LocalName { get; set; }
        public string LocalNameDesc { get; set; }

        [ForeignKey(typeof(Application))]
        public int ApplicationID { get; set; }

        [ForeignKey(typeof(Department))]
        public int? DepartmentID { get; set; }

        [ForeignKey(typeof(SiteCategory))]
        public int SiteCategoryID { get; set; }

        [ForeignKey(typeof(AdministrationArea))]
        public int? AdministrationAreaID { get; set; }

        public string AccessCategory { get; set; }
        public string EstateCategory { get; set; }
        public string NewEstateCategory { get; set; }
        public string InterimCategory { get; set; }
        public string Remarks { get; set; }
        public string AdditionalInformation { get; set; }
        public bool VATRecoverable { get; set; }
        public bool ExcludeFromAccountsReporting { get; set; }

        [ForeignKey(typeof(RiskAssessment))]
        public int? RiskAssessmentID { get; set; }

        [ForeignKey(typeof(ManagementPlan))]
        public int? ManagementPlanID { get; set; }

        [ForeignKey(typeof(Region))]
        public int? RegionID { get; set; }

        [ForeignKey(typeof(ManagementUnit))]
        public int? ParentManagementUnitID { get; set; }

        [ForeignKey(typeof(PortfolioCategory))]
        public int? PortfolioCategoryID { get; set; }

        [ForeignKey(typeof(PortfolioCategory))]
        public int? InterimPortfolioCategoryID { get; set; }

        public bool? ForecastApproved { get; set; }
        public string SummaryDescription { get; set; }
        public string PublishedSummaryDescription { get; set; }
        public string LongTermIntentions { get; set; }
        public string MicrositeURL { get; set; }
        public string Aspect { get; set; }
        public double MinimumAltitude { get; set; }
        public double MaximumAltitude { get; set; }
        public int? WebsiteVisits { get; set; }
        public string GridReference { get; set; }
        public string MainAccessGridReference { get; set; }
        public string PublicAccessDescription { get; set; }
        public string ManagementAccessDescription { get; set; }
        public string DirectionsToMainEntrance { get; set; }
        public string BoundariesDescription { get; set; }
        public string HarvestingComments { get; set; }
        public string DeerCullPlan { get; set; }
        public string PostCode { get; set; }
        public string SpecialSiteFeatures { get; set; }
        public string SuitableForFilming { get; set; }
        public string AntisocialIssues { get; set; }
        public bool? NonStandardKey { get; set; }
        public bool IsPAWS { get; set; }
        public bool IsPotSite { get; set; }
        public bool AllowPOSO { get; set; }
        public bool WCBudget { get; set; }
        public string AdministrationArea { get; set; }
        public bool Disposed { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public System.DateTime LMDT { get; set; }
        public int? LMUID { get; set; }
        public bool IsMainClumpedSite { get; set; }

        [ForeignKey(typeof(ManagementUnit))]
        public int? ClumpedManagementUnitID { get; set; }
        public DateTime? CRDT { get; set; }
        [ForeignKey(typeof(User))]
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }

        [ForeignKey(typeof(User))]
        public int? DLUID { get; set; }

        [ManyToOne]
        public User WoodlandOfficer { get; set; }

        [ManyToOne]
        public User DeputyWoodlandOfficer { get; set; }


        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Region Region { get; set; }



        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Task> Tasks { get; set; }


        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<AcquisitionUnit> AcquisitionUnits { get; set; }
        
    }
}
