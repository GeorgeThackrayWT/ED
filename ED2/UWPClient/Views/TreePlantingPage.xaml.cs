using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

namespace WT.UWP.ED2.Views
{
    public partial class TreePlantingPage : Page
    {

        internal ITreePlantingModel ViewModel;


        public TreePlantingPage()
        {
            InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<ITreePlantingModel>();

            this.DataContext = ViewModel.TreePlantings;
        }

      
    }
}
