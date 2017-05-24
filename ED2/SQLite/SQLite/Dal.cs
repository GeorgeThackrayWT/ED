using System;
using System.Linq;
using DataObjects.DTOS;
using MvvmHelpers;
 

namespace SQLite
{
    public interface ITestDataDal
    {
        //ObservableRangeCollection<ManagementUnit> ManagementUnits { get; }
  //      ObservableRangeCollection<TaskDto> Tasks { get; }
        ObservableRangeCollection<PropertyDto> Properties { get; }
        ObservableRangeCollection<ManagementPlan> ManagementPlans { get; }
        ObservableRangeCollection<Safety> SafetyList { get; }
        ObservableRangeCollection<TreePlantingDto> TreePlantingList { get; }
        ObservableRangeCollection<PublicInformation> PubliocInformations { get; }
        ObservableRangeCollection<Report> Reports { get; }
        ObservableRangeCollection<InternalAudit> InternalAudits { get; }
        ObservableRangeCollection<Document> Documents { get; }



    }

    public class TestDataDal : ITestDataDal
    {
 
        public ObservableRangeCollection<PropertyDto> Properties
        {
            get
            {
                var result = new ObservableRangeCollection<PropertyDto>();

                result.Add(new PropertyDto()
                {
                    CostCentre = "4951",
                    Location = "Felixstowe",
                    Manager = "Michael Ryder",
                    Region = "Central"
                });
                result.Add(new PropertyDto()
                {
                    CostCentre = "4921",
                    Location = "Keynshaw",
                    Manager = "Michael Ryder",
                    Region = "South West"
                });
                result.Add(new PropertyDto()
                {
                    CostCentre = "4203",
                    Location = "Loch Ness",
                    Manager = "Michael Ryder",
                    Region = "Wales"
                });
                result.Add(new PropertyDto()
                {
                    CostCentre = "4867",
                    Location = "Warrington",
                    Manager = "Michael Ryder",
                    Region = "North"
                });

                return result;
            }
        }

        public ObservableRangeCollection<ManagementPlan> ManagementPlans
        {
            get
            {
                var result = new ObservableRangeCollection<ManagementPlan>();

                result.Add(new ManagementPlan()
                {
                    Location = "4951",
                    AccessCategory = "Central",
                    ApprovedBy = "Michael Ryder",
                    Area = "3.91",
                    EstateCategory = "4",
                    PlanFrom = "2014",
                    PlanTo = "2019"
                });


                result.Add(new ManagementPlan()
                {
                    Location = "4929",
                    AccessCategory = "South West",
                    ApprovedBy = "Third Party Manager",
                    Area = "3.91",
                    EstateCategory = "4",
                    PlanFrom = "2014",
                    PlanTo = "2019"
                });

                result.Add(new ManagementPlan()
                {
                    Location = "4203",
                    AccessCategory = "Wales",
                    ApprovedBy = "Ross Watson",
                    Area = "3.91",
                    EstateCategory = "4",
                    PlanFrom = "2015",
                    PlanTo = "2020"
                });

                result.Add(new ManagementPlan()
                {
                    Location = "4867",
                    AccessCategory = "South West",
                    ApprovedBy = "Mark Feather",
                    Area = "3.91",
                    EstateCategory = "4",
                    PlanFrom = "2006",
                    PlanTo = "2011"
                });


                return result;
            }
        }

        public ObservableRangeCollection<Safety> SafetyList
        {
            get
            {
                var result = new ObservableRangeCollection<Safety>();

                result.Add(new Safety()
                {
                    Location = "4951",
                    FireRish = "Central",
                    BiosecurityZone = "Michael Ryder",
                    Hazards = "5",
                    HazardMap = "map link",
                    AuthorisedDate = "29/10/2013",
                    AutherisedBy = "Michael Ryder",
                    ReviewDate = "29/10/2013"

                });

                result.Add(new Safety()
                {
                    Location = "4929",
                    FireRish = "South West",
                    BiosecurityZone = "Chris Matts",
                    Hazards = "6",
                    HazardMap = "map link",
                    AuthorisedDate = "06/03/2017",
                    AutherisedBy = "Chris Matts",
                    ReviewDate = "06/03/2017"

                });

                return result;
            }
        }

        public ObservableRangeCollection<TreePlantingDto> TreePlantingList
        {
            get
            {
                var result = new ObservableRangeCollection<TreePlantingDto>();

                result.Add(new TreePlantingDto()
                {
                    CostCentre = "4951",
                    Region = "Central",
                    Manager = "Michael Ryder",
                    Location = "Felixstowe",
                    WCToPlant = "3.10",
                    WCPlanted = "3.10",
                    WCAvailable = "0.00",
                    TNToPlant = "5,360",
                    TNPlanted = "5,312",
                    TNAvailable = "0",
                    PlantingComplete = "True",
                    SuitableToBeSold = "True"
                });

                result.Add(new TreePlantingDto()
                {
                    CostCentre = "4929",
                    Region = "South West",
                    Manager = "Chris Matts",
                    Location = "Loch Ness",
                    WCToPlant = "0.00",
                    WCPlanted = "4.35",
                    WCAvailable = "0.00",
                    TNToPlant = "4,750",
                    TNPlanted = "6,542",
                    TNAvailable = "0",
                    PlantingComplete = "True",
                    SuitableToBeSold = "True"
                });



                return result;
            }
        }

        public ObservableRangeCollection<PublicInformation> PubliocInformations
        {
            get
            {
                var result = new ObservableRangeCollection<PublicInformation>();

                result.Add(new PublicInformation()
                {
                    Location = "Felixstowe",
                    Directions = "View",
                    EventsThisYear = "False",
                    Facilities = "xxx",
                    GridReference = "SU568494",
                    LocationMap = "Map",
                    PhotoLibrary = "True",
                    PostCode = "TA3 5UJ",
                    WebSiteCount = "2345"
                });

                result.Add(new PublicInformation()
                {
                    Location = "Keynsham",
                    Directions = "View",
                    EventsThisYear = "False",
                    Facilities = "YYY",
                    GridReference = "NH575357",
                    LocationMap = "Map",
                    PhotoLibrary = "True",
                    PostCode = "AL10 9BT",
                    WebSiteCount = "1225"
                });

                return result;
            }
        }

        public ObservableRangeCollection<Report> Reports
        {
            get
            {
                var result = new ObservableRangeCollection<Report>();

                result.Add(new Report()
                {
                    Name = "Public Site Information",
                    Public = true
                });

                result.Add(new Report()
                {
                    Name = "Public Management Plan",
                    Public = true
                });

                result.Add(new Report()
                {
                    Name = "Public Management Plan - Short Version",
                    Public = true
                });

                result.Add(new Report()
                {
                    Name = "Tasks",
                    Public = false
                });

                result.Add(new Report()
                {
                    Name = "Management Plan",
                    Public = false
                });

                return result;
            }

        }

        public ObservableRangeCollection<InternalAudit> InternalAudits
        {
            get
            {
                var result = new ObservableRangeCollection<InternalAudit>();

                result.Add(new InternalAudit()
                {
                    Region = "South East",
                    Manager = "Alissa Wilson",
                    AuditorFirst = "Clive Stewart",
                    AuditorSecond = "",
                    AuditDate = "23/02/2017",
                    AutherisedCorrectBy = "",
                    AutherisedCorrectDate = "",
                    CertifiedCorrectBy = "",
                    CertifiedCorrectDate = ""
                });

                result.Add(new InternalAudit()
                {
                    Region = "North",
                    Manager = "Mark Feather",
                    AuditorFirst = "Nick Hall",
                    AuditorSecond = "Alistair Nash",
                    AuditDate = "21/03/2017",
                    AutherisedCorrectBy = "Alistair Nash",
                    AutherisedCorrectDate = "21/03/2017",
                    CertifiedCorrectBy = "Alistair Nash",
                    CertifiedCorrectDate = "21/03/2017"
                });


                return result;
            }
        }

        public ObservableRangeCollection<Document> Documents
        {
            get
            {
                var result = new ObservableRangeCollection<Document>();

                result.Add(new Document()
                {
                    Cabinet = "Estate",
                    ContentType = "application/pdf",
                    Date = "08/03/2017",
                    DocumentName = "Management Plan",
                    FileName = "Public Management Plan (4165)",
                    ErrorMessage = "",
                    Length = "205.6kb",
                    Status = "Pending",
                    UserName = "Malcolm Allen"
                });

                result.Add(new Document()
                {
                    Cabinet = "Estate",
                    ContentType = "application/pdf",
                    Date = "08/03/2017",
                    DocumentName = "Management Plan",
                    FileName = "Public Management Plan (4165)",
                    ErrorMessage = "",
                    Length = "194.6kb",
                    Status = "Pending",
                    UserName = "Malcolm Allen"
                });


                return result;
            }
        }

    }
}
