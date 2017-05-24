using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

namespace WT.UWP.ED2.Views
{
    public partial class ManagementUnitMain : Page
    {
        internal IManagementUnitModel ViewModel;

        public ManagementUnitMain()
        {
            Debug.WriteLine("ManagementUnitMain loading");

            InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<IManagementUnitModel>();

            this.DataContext = ViewModel.ManagementUnits;

            Debug.WriteLine("ManagementUnitMain loaded");

        }

 
    }
}
