using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using EDCORE.ViewModel;
using FreshMvvm;
using System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WT.UWP.ED2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ITaskListViewModel ViewModel { get; set; }

        public MainPage()
        {
            Debug.WriteLine("MainPage loading");

            this.InitializeComponent();
            
            ViewModel = FreshIOC.Container.Resolve<ITaskListViewModel>();
       
            this.DataContext = ViewModel;

            Debug.WriteLine("MainPage loaded");
        }
        
    }
}
