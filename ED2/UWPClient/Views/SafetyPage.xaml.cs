using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

namespace WT.UWP.ED2.Views
{
    public partial class SafetyPage : Page
    {

        internal ISafetyModel ViewModel;


        public SafetyPage()
        {
            InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<ISafetyModel>();

            this.DataContext = ViewModel.SafetyLists;
        }

         
    }
}
