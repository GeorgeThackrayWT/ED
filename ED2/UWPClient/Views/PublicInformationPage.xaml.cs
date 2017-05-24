using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

namespace WT.UWP.ED2.Views
{
    public partial class PublicInformationPage : Page
    {

        internal IPublicInformationModel ViewModel;


        public PublicInformationPage()
        {
            InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<IPublicInformationModel>();

            this.DataContext = ViewModel.PublicProperties;


        }
         
    }
}
