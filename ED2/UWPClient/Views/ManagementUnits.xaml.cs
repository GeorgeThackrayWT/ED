using System;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using EDCORE.ViewModel;
using FreshMvvm;
using Telerik.UI.Xaml.Controls.Grid;

namespace WT.UWP.ED2.Views
{   
    public class ComboBoxItemConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {             
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {            
            return (ApplicationDto)value;
        }
    }





   
    
    public sealed partial class ManagementUnits : UserControl
    {

        internal IManagementUnitModel ViewModel;

      
        public ManagementUnits()
        {
            Debug.WriteLine("ManagementUnits loading");

            InitializeComponent();

            ViewModel = FreshIOC.Container.Resolve<IManagementUnitModel>();

            this.DataContext = ViewModel.ManagementUnits;

            Debug.WriteLine("ManagementUnits loaded");

            
        }

       
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, Telerik.UI.Xaml.Controls.Grid.DataGridSelectionChangedEventArgs e)
        {

        }
    }
}
