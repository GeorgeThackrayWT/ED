using FreshMvvm;
using SQLite;
using Xamarin.Forms;

namespace Xamarin
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

            var iTestDataDal = FreshIOC.Container.Resolve<ITestDataDal>();

		    //	var page = FreshPageModelResolver.ResolvePageModel<ITestDataDal>();
		    //	var navContainer = new FreshNavigationContainer(page);
		    //	MainPage = navContainer;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
