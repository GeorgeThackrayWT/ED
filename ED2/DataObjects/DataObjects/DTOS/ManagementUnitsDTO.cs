using MvvmHelpers;

namespace DataObjects
{
    public class ManagementUnitsDTO : ObservableObject
    {
        public int ManagementUnitId { get; set; }

        public string Name { get; set; }

        public string WoodlandOfficer { get; set; }

        public string DeputyWoodlandOfficer { get; set; }

 
    }
}