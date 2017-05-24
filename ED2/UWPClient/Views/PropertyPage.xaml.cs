using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;


namespace WT.UWP.ED2.Views
{
    public sealed partial class PropertyPage : Page
    {
        public IPropertyModel ViewModel { get; set; }

        public PropertyPage()
        {
            this.InitializeComponent();
            
            ViewModel = FreshIOC.Container.Resolve<IPropertyModel>();

            this.DataContext = ViewModel.Properties;

        }

   
    }
}
