using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

namespace WT.UWP.ED2.Views
{
    public partial class MapPage : Page
    {

        internal IMapsModel ViewModel;

        public MapPage()
        {
            InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<IMapsModel>();

            
        }

     
    }
}
