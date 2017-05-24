using System.Collections.Generic;
using System.Threading.Tasks;
using DataObjects.DAOS;
using DataObjects.DTOS;
using EDCORE.ViewModel;

namespace Abstractions
{
    public interface IMenuStore : IBaseStore
    {
        Task<IEnumerable<MenuDTO>> GetMenusAsync(int skip = 0, int take = 100, bool forceRefresh = false);

        List<ApplicationDto> GetApplications();

        //get all menus
        //create menus

        System.Threading.Tasks.Task CreateMenusAsynch();

        System.Threading.Tasks.Task AddMenuData();



    }
}