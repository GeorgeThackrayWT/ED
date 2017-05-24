using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;
using SQLiteNetExtensionsAsync.Extensions;
using WTSqLExtAsync.Extensions;

namespace Stores
{
    public class TaskStore : BaseStore, ITaskStore
    {
      
        public TaskStore(IPlatform platform)
        {
            _platform = platform;
            _sqLiteAsyncConnection = GetConnection();            
        }
       
        public async Task<IEnumerable<SimpleTaskDTO>> GetSimpleTasksAsync(int skip = 0, int take = 100, bool forceRefresh = false)
        {
            var returnList0 = new List<DataObjects.SimpleTaskDTO>();
                   
            var r1 = await _sqLiteAsyncConnection.GetAllWithChildrenAsync<DataObjects.DAOS.Task>(
                filter: p=> (p.ID >= 51901 && p.ID <= 53906),
                orderExpr: null,
                limit: 25,
                offset: 0,
                recursive:0);           
             
            returnList0.AddRange(r1.Select(t => new DataObjects.SimpleTaskDTO()
            {   
                                 
                Amount = t.Amount ?? 0,
                Manager = t.ManagementUnit.GetIFNull().WoodlandOfficer.DisplayName,
                Category = t.TaskCategory.Description,
                Notes = t.Notes,
                Region = t.ManagementUnit.GetIFNull().Region.Description,
                TaskId = t.ID

            }));
            

            return returnList0;
        }
  
        public async Task<IEnumerable<SimpleTaskDTO>> GetTasks(DateRangeFilter dateRangeFilter, int managementUnitId =0)
        {
            var returnList0 = new List<DataObjects.SimpleTaskDTO>();

            List<DataObjects.DAOS.Task> tasks = new List<DataObjects.DAOS.Task>();


            if (managementUnitId == 0)
            {
                tasks = await _sqLiteAsyncConnection.GetAllWithChildrenAsync<DataObjects.DAOS.Task>(
                    filter: p => (p.DeadlineDate >= dateRangeFilter.From && 
                    p.DeadlineDate <= dateRangeFilter.To && p.Deleted == false && p.CompletedDate!=null),
                    orderExpr: null,
                    limit: 25,
                    offset: 0,
                    recursive: 0);
            }
            else
            {
                tasks = await _sqLiteAsyncConnection.GetAllWithChildrenAsync<DataObjects.DAOS.Task>(
                    filter: p => (p.DeadlineDate >= dateRangeFilter.From && p.DeadlineDate <= dateRangeFilter.To) && p.ManagementUnitID == managementUnitId ,
                    orderExpr: null,
                    limit: 25,
                    offset: 0,
                    recursive: 0);
            }
            
            returnList0.AddRange(tasks.Select(t => new DataObjects.SimpleTaskDTO()
            {

                Amount = t.Amount ?? 0,
                Manager = t.ManagementUnit.GetIFNull().WoodlandOfficer.DisplayName,
                Category = t.TaskCategory.Description,
                Notes = t.Notes,
                Region = t.ManagementUnit.GetIFNull().Region.Description,
                TaskId = t.ID,
                Deadline = t.DeadlineDate
            }));


            return returnList0;
        }
        
    }   
}