using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using DataObjects;
using DataObjects.DTOS;
using MvvmHelpers;
using SQLite;

namespace EDCORE.ViewModel
{
    public interface IPropertyModel : INotifyPropertyChanged
    {
        ObservableRangeCollection<PropertyDto> Properties { get;}
    }

    public class PropertyModel : ViewModelBase, IPropertyModel
    {
        private readonly ITestDataDal _testDataDal;
        private readonly IManagementUnitStore _managementUnitStore;
        public ObservableRangeCollection<PropertyDto> Properties { get;  } 
            = new ObservableRangeCollection<PropertyDto>();
        
        public PropertyModel(ITestDataDal iTestDataDal, IManagementUnitStore iManagementUnitStore)
        {
            _testDataDal = iTestDataDal;
            _managementUnitStore = iManagementUnitStore;

            Debug.WriteLine("loading properties");
            LoadPropertyList();
        }

        public async Task LoadPropertyList()
        {            
            try
            {
                var items = await _managementUnitStore.GetPropertyList();
                Debug.WriteLine("finished loading properties");
                Properties.ReplaceRange(items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}