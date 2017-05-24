using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

namespace WT.UWP.ED2.Views
{
    public sealed partial class ReportsPage : Page
    {
        internal IReportsModel ViewModel;

        public ReportsPage()
        {
            InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<IReportsModel>();

            this.DataContext = ViewModel.Reports;
             
        }

        
    }
}
