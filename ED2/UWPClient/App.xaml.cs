using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Abstractions;
using EDCORE.Helpers;
using EDCORE.ViewModel;
using FreshMvvm;
using Mvvm.Services;
using SQLite;
using Stores;
using WT.ED2.UWP.Helpers;
using WT.UWP.ED2.Views;

namespace WT.ED2.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;


            FreshIOC.Container.Register<IPageLookup, PageLookup>();

            FreshIOC.Container.Register<ITestDataDal, TestDataDal>();

            FreshIOC.Container.Register<IMenuStore, MenuStore>();

            FreshIOC.Container.Register<ITaskStore, TaskStore>();

            FreshIOC.Container.Register<IManagementUnitStore, ManagementUnitStore>();

            FreshIOC.Container.Register<IManagementUnitModel, ManagementUnitModel>();

            FreshIOC.Container.Register<IDocumentsModel, DocumentsModel>();

            FreshIOC.Container.Register<IInternalAuditModel, InternalAuditModel>();

            FreshIOC.Container.Register<IMapsModel, MapsModel>();

            FreshIOC.Container.Register<IReportsModel, ReportsModel>();

            FreshIOC.Container.Register<IManagementPlanModel, ManagementPlanModel>();

            FreshIOC.Container.Register<IPublicInformationModel, PublicInformationModel>();

            FreshIOC.Container.Register<IShellViewModel, ShellViewModel>();

            FreshIOC.Container.Register<ISafetyModel, SafetyModel>();

            FreshIOC.Container.Register<IPropertyModel, PropertyModel>();

            FreshIOC.Container.Register<IAdministrativeAreaModel, AdministrativeAreaModel>();
            
            FreshIOC.Container.Register<ITreePlantingModel, TreePlantingModel>();

            FreshIOC.Container.Register<IMenuItemCollection, MenuItemCollection>();

            FreshIOC.Container.Register<INavigation, Navigation>();

            FreshIOC.Container.Register<IPlatform, WindowsPlatform>();

            FreshIOC.Container.Register<ISelectedManagementUnit, DataGridInfoConverter>();

            FreshIOC.Container.Register<ITaskListViewModel, TaskListViewModel>();

            FreshIOC.Container.Register<IMyEventAggregator, MyEventAggregator>();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                Theme.ApplyToContainer();

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(WT.UWP.ED2.Views.Shell), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
