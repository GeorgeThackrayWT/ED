using System;
using WTSqLExt.Attributes;
using System.Collections.Generic;
using MvvmHelpers;
using SQLite.Net.Attributes;
using SQLiteNetExtensionsAsync.Extensions;

namespace DataObjects.DAOS
{
     
    [Table("AcquisitionUnit")]
    public class AcquisitionUnit : WtDataObject<AcquisitionUnit>
    {
        [PrimaryKey, AutoIncrement]  
        public int ID { get; set; }


        [ForeignKey(typeof(ManagementUnit))]
        public int ManagementUnitID { get; set; }

        [ForeignKey(typeof(AcquisitionUnit))]
        public int ParentAcquisitionUnitID { get; set; }

        [ForeignKey(typeof(User))]
        public int WoodlandOfficerID { get; set; }

        [ForeignKey(typeof(User))]
        public int? AcquisitionOfficerID { get; set; }

        [ForeignKey(typeof(Farming))]
        public int? FarmingID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string GeneralLocation { get; set; }

        [ForeignKey(typeof(AdministrationArea))]
        public int? AdministrationAreaID { get; set; }

        public DateTime? MTMDateApproved { get; set; }

        public DateTime? DateContractExchanged { get; set; }

        public DateTime? DateContractCompleted { get; set; }

        public DateTime? DateDisposed { get; set; }

        public DateTime? DateArchived { get; set; }

        public bool OwnedByWoodlandTrust { get; set; }

        public string Description { get; set; }

        public string SummaryDescription { get; set; }

        public string ManagementInformation { get; set; }

        public bool CompletionPending { get; set; }

        public string District { get; set; }

        public string Parish { get; set; }

        public string PublicAccessDescription { get; set; }

        public string ManagementAccessDescription { get; set; }

        public string BoundariesDescription { get; set; }

        public bool UpdateBoundaryDescription { get; set; }

        public DateTime? UpdateBoundaryDescriptionDate { get; set; }

        public string PublicRightsOfWayComments { get; set; }

        public string Aspect { get; set; }

        public string HarvestingComments { get; set; }

        public string DeerCullPlan { get; set; }

        public double Easting { get; set; }

        public double Northing { get; set; }

        public long DirectoryInformation { get; set; }

        public long? CombinedDirectoryInformation { get; set; }

        
        public int TypeID { get; set; }

        public bool GiftConditionsExist { get; set; }

        public string PublicAccessDescriptionLegal { get; set; }

        public string ManagementAccessDescriptionLegal { get; set; }

        public int? ShootingRightsID { get; set; }

        public string ShootingRightsDescription { get; set; }


        
        public int? MineralRightsID { get; set; }

        public string MineralRightsDescription { get; set; }

        public string BoundariesDescriptionLegal { get; set; }

        public bool? DrainageRatesExist { get; set; }

        public bool? HasPublicRightsOfWay { get; set; }


        [ForeignKey(typeof(HighwayAuthority))]
        public int? HighwayAuthorityID { get; set; }

        public DateTime? HighwaysActDate { get; set; }

        public DateTime? NextHighwaysActDate { get; set; }

        public DateTime? StatutoryDeclarationsDate { get; set; }

        public DateTime? NextStatutoryDeclarationsDate { get; set; }

        public bool AreDeedsSilent { get; set; }

        public DateTime? DateLeasedTo3rdParty { get; set; }

        public int? ThirdPartyLeaseTerm { get; set; }

        public bool ThirdPartyRights { get; set; }

        public string ThirdPartyRightsDescription { get; set; }

        public bool ServicesExist { get; set; }

        public string ServicesDescription { get; set; }

        public string MAFFHoldingNumber { get; set; }

        public bool RestrictiveCovenants { get; set; }

        public string RestrictiveCovenantsDescription { get; set; }

        public bool BeneficialCovenants { get; set; }

        public string BeneficialCovenantsDescription { get; set; }

        public bool Structures { get; set; }

        public string StructuresDescription { get; set; }

        public string AdditionalInformation { get; set; }

        public bool OtherRightsConveyed { get; set; }

        public string OtherRightsConveyedDescription { get; set; }

        public bool? PermissiveAccess { get; set; }

        public string PermissiveAccessDescription { get; set; }

        public string ContaminationDescription { get; set; }

        public string HazardsAndLiabilities { get; set; }

        public string FormerNames { get; set; }
        public double AreaInHectares { get; set; }

        
        public int? SellerDonorID { get; set; }
        public int? SellerDonorAgentID { get; set; }
        public int? SellerDonorSolicitorID { get; set; }
        public bool? HasPhotos { get; set; }
        public double? PreAcquisitionWoodAreaInHectares { get; set; }
        public double? PreAcquisitionLandAreaInHectares { get; set; }
        public double? PurchasePrice { get; set; }
        public string GridReference { get; set; }
        public string PostCode { get; set; }
        public string AdministrationArea { get; set; }
        public double? WoodAreaInHectares { get; set; }
        public double? GISAreaInHectares { get; set; }

        [ForeignKey(typeof(County))]
        public int? CountyID { get; set; }

        public bool? NonFSC { get; set; }
        public double? NonFSCInHectares { get; set; }
        public string NonFSCComments { get; set; }
        public int? NonFSCTypeID { get; set; }
        public DateTime? NonFSCAsOfDate { get; set; }
        public bool? T4A { get; set; }
        public bool? WOYD { get; set; }
        public bool? Trafalgar { get; set; }
        public bool? DIO { get; set; }

        [ForeignKey(typeof(Tenure))]
        public int? TenureID { get; set; }
        public int? LeaseTerm { get; set; }
        public DateTime? LeaseStartDate { get; set; }
        public DateTime? LeaseEndDate { get; set; }
        public double? Rent { get; set; }
        public string Lessor { get; set; }
        public string Lessee { get; set; }
        public string WTSolicitorsName { get; set; }
        public bool? CLT { get; set; }
        public int? Explorer { get; set; }
        public int? Landranger { get; set; }

        [ForeignKey(typeof(User))]
        public int ManagedByID { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public System.DateTime LMDT { get; set; }
        public int LMUID { get; set; }
        public DateTime? CRDT { get; set; }
        [ForeignKey(typeof(User))]
        public int? CRUID { get; set; }
        public DateTime? DLDT { get; set; }
        [ForeignKey(typeof(User))]
        public int? DLUID { get; set; }
        public string TestNew { get; set; }


    
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Task> Tasks { get; set; }


        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public ManagementUnit ManagementUnit { get; set; }


        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Tenure Tenure { get; set; }
    }
}
