using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

namespace WT.UWP.ED2.Views
{
    public sealed partial class ManagementPlansPage : Page
    {
        internal IManagementPlanModel ViewModel;

        public ManagementPlansPage()
        {
            Debug.WriteLine("ManagementPlansPage loading");

            this.InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<IManagementPlanModel>();

            this.DataContext = ViewModel.ManagementPlans;

            Debug.WriteLine("ManagementPlansPage loaded");
        }

       
    }
}
