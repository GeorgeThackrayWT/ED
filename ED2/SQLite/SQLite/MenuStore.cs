using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS;
using EDCORE.ViewModel;
using SQLiteNetExtensionsAsync.Extensions;
using WTSqLExtAsync.Extensions;
using Task = System.Threading.Tasks.Task;

namespace Stores
{
    public class MenuStore : BaseStore, IMenuStore
    { 

      
        public MenuStore(IPlatform platform)
        {
            _platform = platform;

            _sqLiteAsyncConnection = GetConnection();
        }
 
      
        public async Task<IEnumerable<MenuDTO>> GetMenusAsync(int skip = 0, int take = 100, bool forceRefresh = false)
        {
            var returnList0 = new List<MenuDTO>();

            var r1 = _sqLiteAsyncConnection.GetAllWithChildrenAsync<Menu>(
                filter: null,
                orderExpr: null,
                limit: 25,
                offset: 0,
                recursive: 0);

            r1.Wait();


            returnList0.AddRange(r1.Result.Select(t => new MenuDTO()
            {
                Caption = t.Caption,
                Destination = t.Destination,
                Id = t.ID,
                ParentMenuId = t.ParentMenuId

            }));


            return returnList0;
        }

        public async Task CreateMenusAsynch()
        {
            //await Task.Run(() =>
            // {
            //     var tableCreatedResult = _sqLiteAsyncConnection.CreateTableAsync<Menu>().ContinueWith(t =>
            //     {
            //         Debug.WriteLine("Table created!");
            //     });
            // });
            
            await Task.Run(async () =>
            {
               await _sqLiteAsyncConnection.CreateTableAsync<Menu>();
            });

        }

        public async Task AddMenuData()
        {

            var delResult =_sqLiteAsyncConnection.DeleteAllAsync<Menu>();

            delResult.Wait();

            var topMenu = new List<Menu>
            {
                new Menu {ID = 1, Caption = "Tasks", Destination = "tasks", ParentMenuId = 0},
                new Menu {ID = 2, Caption = "Property", Destination = "property", ParentMenuId = 0},
                new Menu {ID = 3, Caption = "Management Plans", Destination = "managementplans", ParentMenuId = 0},
                new Menu {ID = 4, Caption = "Safety", Destination = "safety", ParentMenuId = 0},
                new Menu {ID = 5, Caption = "Tree Planting", Destination = "treeplanting", ParentMenuId = 0},
                new Menu {ID = 6, Caption = "Public Information", Destination = "publicinformation", ParentMenuId = 0},
                new Menu {ID = 7, Caption = "Maps", Destination = "maps", ParentMenuId = 0},
                new Menu {ID = 8, Caption = "Reports", Destination = "reports", ParentMenuId = 0},
                new Menu {ID = 9, Caption = "Internal Audits", Destination = "internalaudits", ParentMenuId = 0},
                new Menu {ID = 10, Caption = "Documents", Destination = "documents", ParentMenuId = 0},
                new Menu { ID = 11, Caption = "Administration Area", Destination = "administrationarea", ParentMenuId = 0  }
            };


            var tasksMenu = new List<Menu>
            {
                new Menu {ID = 12, Caption = "Today", Destination = "taskstoday", ParentMenuId = 1},
                new Menu {ID = 13, Caption = "Week", Destination = "taskweek", ParentMenuId = 1},
                new Menu {ID = 14, Caption = "Month", Destination = "taskmonth", ParentMenuId = 1},
                new Menu {ID = 15, Caption = "Year", Destination = "taskyear", ParentMenuId = 1},
                new Menu {ID = 16, Caption = "All", Destination = "taskall", ParentMenuId = 1}
            };

            var managementPlansMenu = new List<Menu>
            {
                new Menu {ID = 17, Caption = "Administration", Destination = "administration", ParentMenuId = 3},
                new Menu {ID = 18, Caption = "Grant Contracts", Destination = "grantcontracts", ParentMenuId = 3},
                new Menu {ID = 19, Caption = "Condition Assessment", Destination = "conditionassessment", ParentMenuId = 3},
                new Menu {ID = 20, Caption = "Summary Description", Destination = "summarydescription", ParentMenuId = 3},
                new Menu {ID = 21, Caption = "Objectives KF", Destination = "objectiveskf", ParentMenuId = 3},
                new Menu {ID = 22, Caption = "Work Programme", Destination = "workprogramme", ParentMenuId = 3},
                new Menu {ID = 23, Caption = "Purchase Orders", Destination = "purchaseorders", ParentMenuId = 3},
                new Menu {ID = 24, Caption = "Sales Orders", Destination = "salesorders", ParentMenuId = 3},
                new Menu {ID = 25, Caption = "Monitoring", Destination = "monitoring", ParentMenuId = 3},
                new Menu {ID = 26, Caption = "Harvesting", Destination = "harvesting", ParentMenuId = 3},
                new Menu {ID = 27, Caption = "Reference Information", Destination = "referenceinformation", ParentMenuId = 3}
            };


            await Task.Run(async () =>
            {
                await _sqLiteAsyncConnection.InsertAllAsync(topMenu);

                await _sqLiteAsyncConnection.InsertAllAsync(tasksMenu);

                await _sqLiteAsyncConnection.InsertAllAsync(managementPlansMenu);
            });
            
        }

        public List<ApplicationDto> GetApplications()
        {         
            var items = new List<ApplicationDto>
            {
                new ApplicationDto() {ID = "99", Name = "All"},
                new ApplicationDto() {ID = "1", Name = "ED"},
                new ApplicationDto() {ID = "2", Name = "NED"}
            };            
            return items;
        }
    }

   
}