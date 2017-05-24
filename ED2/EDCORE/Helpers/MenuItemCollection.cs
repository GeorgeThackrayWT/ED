using System.Collections.ObjectModel;

namespace EDCORE.Helpers
{


    public interface IMenuItemCollection
    {

        ObservableCollection<MenuItem> GetTopMenu();

        ObservableCollection<MenuItem> GetSubMenu();

        ObservableCollection<MenuItem> GetSideMenu();
    }


}
