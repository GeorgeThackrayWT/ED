using System.Collections.ObjectModel;
using System.ComponentModel;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{


    public interface IShellViewModel : INotifyPropertyChanged
    {
      
        ObservableCollection<MenuItem> SideMenu { get; }

        ObservableCollection<MenuItem> TopMenu { get; }

        ObservableCollection<MenuItem> SubMenu { get; }
 
    }


    public class ShellViewModel : ViewModelBase, IShellViewModel
    {
     

        private readonly IMenuItemCollection _iMenu;

  
        public ObservableCollection<MenuItem> SideMenu { get; }

        public ObservableCollection<MenuItem> TopMenu { get; }

        public ObservableCollection<MenuItem> SubMenu { get; }

        public ShellViewModel()
        {

        }

        public ShellViewModel(IMenuItemCollection iMenu)
        {
            _iMenu = iMenu;
           

    

            SideMenu = iMenu.GetSideMenu();
            TopMenu = iMenu.GetTopMenu();
            SubMenu = iMenu.GetSubMenu();

        }

      
    }
}
