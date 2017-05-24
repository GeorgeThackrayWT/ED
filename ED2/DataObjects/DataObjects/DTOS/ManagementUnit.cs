namespace DataObjects.DTOS
{
    public class ManagementUnit
    {
        public string Name { get; set; }
    }

    public class ManagementPlan
    {
        public string Location { get; set; }

        public string Area { get; set; }

        public string AccessCategory { get; set; }

        public string EstateCategory { get; set; }

        public string PlanFrom { get; set; }

        public string PlanTo { get; set; }

        public string ApprovedBy { get; set; }
    }

    public class Safety
    {
        public string Location { get; set; }

        public string FireRish { get; set; }

        public string BiosecurityZone { get; set; }

        public string Hazards { get; set; }

        public string HazardMap { get; set; }

        public string AuthorisedDate { get; set; }

        public string AutherisedBy { get; set; }

        public string ReviewDate { get; set; }
        

    }


    public class TreePlantingDto
    {
        public string CostCentre { get; set; }

        public string Region { get; set; }

        public string Manager { get; set; }

        public string Location { get; set; }

        public string WCToPlant { get; set; }

        public string WCPlanted { get; set; }

        public string WCAvailable { get; set; }

        public string TNToPlant { get; set; }

        public string TNPlanted { get; set; }

        public string TNAvailable { get; set; }

        public string PlantingComplete { get; set; }

        public string SuitableToBeSold { get; set; }
    }

    public class PublicInformation
    {
        public string Location { get; set; }

        public string GridReference { get; set; }

        public string PostCode { get; set; }

        public string Directions { get; set; }

        public string LocationMap { get; set; }

        public string WebSiteCount { get; set; }

        public string EventsThisYear { get; set; }

        public string PhotoLibrary { get; set; }

        public string Facilities { get; set; }
    }

    public class Report
    {
        public string Name { get; set; }

        public bool Public { get; set; }
    }

    public class InternalAudit
    {
        public string AuditDate { get; set; }

        public string Region { get; set; }

        public string Manager { get; set; }

        public string AuditorFirst { get; set; }

        public string AuditorSecond { get; set; }

        public string CertifiedCorrectBy { get; set; }

        public string CertifiedCorrectDate { get; set; }

        public string AutherisedCorrectBy { get; set; }

        public string AutherisedCorrectDate { get; set; }
    }

    public class Document
    {
        public string DocumentName { get; set; }
        public string Cabinet { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }

        public string Length { get; set; }

        public string Status { get; set; }

        public string ErrorMessage { get; set; }

        public string Date { get; set; }

        public string UserName { get; set; }

    }
}