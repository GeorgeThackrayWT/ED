using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WT.UWP.ED2.Views;

namespace EDCORE.Helpers
{
    public class PageLookup : IPageLookup
    {
        public System.Type PageType(string typeName)
        {
            Type retVal = typeof(MainPage);

            switch (typeName)
            {
                case "tasks":
                    retVal = typeof(MainPage);
                    break;
                case "taskstoday":
                    retVal = typeof(MainPage);
                    break;
                case "taskweek":
                    retVal = typeof(MainPage);
                    break;
                case "taskmonth":
                    retVal = typeof(MainPage);
                    break;
                case "taskyear":
                    retVal = typeof(MainPage);
                    break;
                case "taskall":
                    retVal = typeof(MainPage);
                    break;

                case "property":
                    retVal = typeof(PropertyPage);
                    break;
                case "managementplans":
                    retVal = typeof(ManagementPlansPage);
                    break;
                case "safety":
                    retVal = typeof(SafetyPage);
                    break;
                case "treeplanting":
                    retVal = typeof(MainPage);
                    break;
                case "publicinformation":
                    retVal = typeof(PropertyPage);
                    break;
                case "maps":
                    retVal = typeof(ManagementPlansPage);
                    break;
                case "reports":
                    retVal = typeof(SafetyPage);
                    break;
                case "internalaudits":
                    retVal = typeof(MainPage);
                    break;
                case "documents":
                    retVal = typeof(PropertyPage);
                    break;
                case "administrationarea":
                    retVal = typeof(ManagementPlansPage);
                    break;
               
                case "administration":
                    retVal = typeof(ManagementPlansPage);
                    break;
                case "grantcontracts":
                    retVal = typeof(SafetyPage);
                    break;
                case "conditionassessment":
                    retVal = typeof(TreePlantingPage);
                    break;
                case "summarydescription":
                    retVal = typeof(PublicInformationPage);
                    break;
                case "objectiveskf":
                    retVal = typeof(MapPage);
                    break;
                case "workprogramme":
                    retVal = typeof(AdminArea);
                    break;
                case "purchaseorders":
                    retVal = typeof(TreePlantingPage);
                    break;
                case "salesorders":
                    retVal = typeof(PublicInformationPage);
                    break;
                case "monitoring":
                    retVal = typeof(MapPage);
                    break;
                case "harvesting":
                    retVal = typeof(AdminArea);
                    break;
                case "referenceinformation":
                    retVal = typeof(AdminArea);
                    break;


            }

            return retVal;
        }
    }
}
