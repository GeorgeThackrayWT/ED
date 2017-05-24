using System.Collections.Generic;
using System.Threading.Tasks;
using DataObjects;
using DataObjects.DTOS;
using Task = DataObjects.DAOS.Task;

namespace Abstractions
{
    public interface ITaskStore : IBaseStore
    {
        Task<IEnumerable<SimpleTaskDTO>> GetSimpleTasksAsync(int skip = 0, int take = 100, bool forceRefresh = false);

        Task<IEnumerable<SimpleTaskDTO>> GetTasks(DateRangeFilter dateRangeFilter, int managementUnitId =0);    
    }


    public interface IPropertyStore : IBaseStore
    {
     
    }
}