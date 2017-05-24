using System.Diagnostics;
using Windows.UI.Xaml.Controls;

namespace WT.UWP.ED2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            Debug.WriteLine("AboutPage loading");
            this.InitializeComponent();
        }
    }
}
