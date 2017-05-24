using System.Diagnostics;
using Mvvm;
using System.Linq;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using FreshMvvm;
using Mvvm.Services;
using System;
using EDCORE.Helpers;
using EDCORE.ViewModel;

namespace WT.UWP.ED2.Views
{
    public sealed partial class Shell : ISubscriber<EdMessage>
    {
        public IShellViewModel ViewModel { get; set; }

        private INavigation _navigation;

        private IMyEventAggregator _myEventAggregator;

        public Shell()
        {
            InitializeComponent();

            //     ViewModel = FreshIOC.Container.Resolve<TaskListViewModel>();

          //  _myEventAggregator = new MyEventAggregator();
            

            _navigation = FreshIOC.Container.Resolve<INavigation>();
            _myEventAggregator = FreshIOC.Container.Resolve<IMyEventAggregator>();
            _myEventAggregator.Subscribe(this);

            // Initialize Navigation Service.
            _navigation.Frame = SplitViewFrame;

            // Navigate to main page.
            _navigation.Navigate(typeof(MainPage));


            ViewModel = FreshIOC.Container.Resolve<IShellViewModel>();

           // this.DataContext = ViewModel;


        }

        // Navigate to another page.
        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {               
                var menuItem = e.AddedItems.First() as MenuItem;
                if (menuItem != null && menuItem.IsNavigation)
                {
                    _navigation.Navigate(menuItem.NavigationDestination);
                }
            }
        }
         

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Debug.WriteLine("Shell OnNavigatedTo");

            _navigation.EnableBackButton();
            base.OnNavigatedTo(e);

            Debug.WriteLine("Shell OnNavigatedTo finished");
        }
 
        // Open or close the splitview panel through Hamburger button.
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void SplitViewFrame_OnNavigated(object sender, NavigationEventArgs e)
        {
 
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("Item clicked");
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("TextBlock_SelectionChanged");
        }

        private void itemGV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gv = (GridView) sender;
            var si = (MenuItem) gv.SelectedItem;

            if (si != null)
            {
                Debug.WriteLine("itemGV_SelectionChanged : " + si.Text);

                if (!_navigation.OnPage(si.NavigationDestination))
                {
                    _navigation.Navigate(si.NavigationDestination);
                }
                else
                {
                    _myEventAggregator.Publish(new EdMessage
                    {
                        EdEvent = EdEvent.TaskFilterChanged,
                        Data = si.Param
                    });
                }                
            }

        }

        public void HandleMessage(EdMessage message)
        {
            Debug.WriteLine("shell message received: " +message);
        }
    }
}
