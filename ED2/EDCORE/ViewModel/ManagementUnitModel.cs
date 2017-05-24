using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using DataObjects;
using EDCORE.Helpers;
using MvvmHelpers;
using SQLite;

namespace EDCORE.ViewModel
{

 

    public interface IManagementUnitModel: INotifyPropertyChanged
    {
       
        int SelectedItem { get; set; }

        ApplicationDto SelectedComboBoxOption { get; set; }

      
        ObservableRangeCollection<ManagementUnitsDTO> ManagementUnits { get; }

        ObservableCollection<ApplicationDto> ComboBoxOptions { get; }

        ICommand Refresh { get; }
       
    }

   
    public class ManagementUnitModel : ViewModelBase, IManagementUnitModel, ISubscriber<EdMessage>
    {
        private readonly ITestDataDal _testDataDal;
        private readonly ISelectedManagementUnit _iSelectedManagementUnit;
        private readonly IManagementUnitStore _managementUnitStore;
        private readonly IMyEventAggregator _myEventAggregator;
        private readonly ObservableRangeCollection<ManagementUnitsDTO> _managementUnits 
            = new ObservableRangeCollection<ManagementUnitsDTO>();
        private readonly ObservableCollection<ApplicationDto> _comboBoxOptions 
            = new ObservableCollection<ApplicationDto>();
        ApplicationDto _SelectedComboBoxOption;
  
      
        public ObservableRangeCollection<ManagementUnitsDTO> ManagementUnits => _managementUnits;

        public ICommand Refresh => new RelayCommand<object>(ListTypeComboSelectionChangedCmdExec);

        public ObservableCollection<ApplicationDto> ComboBoxOptions => _comboBoxOptions;

        private void ListTypeComboSelectionChangedCmdExec(object listType)
        {
            var result = _iSelectedManagementUnit.RecordId(listType);

            _myEventAggregator.Publish(new EdMessage
            {
                EdEvent = EdEvent.ManagementUnitChanged,
                Data = result
            });

            Debug.WriteLine("selected id : " + result);
        }

        public event PropertyChangedEventHandler PropertyChanged;



        public ManagementUnitModel(ITestDataDal iTestDataDal, 
            IManagementUnitStore iManagementUnitStore, 
            IMenuStore iMenuStore,
            ISelectedManagementUnit iSelectedManagementUnit,
            IMyEventAggregator iMyEventAggregator
            )
        {
            _testDataDal = iTestDataDal;
            _managementUnitStore = iManagementUnitStore;
            _iSelectedManagementUnit = iSelectedManagementUnit;
            _myEventAggregator = iMyEventAggregator;
            _myEventAggregator.Subscribe(this);

            var cbItems = iMenuStore.GetApplications();

            _comboBoxOptions.Clear();
            foreach (var p in cbItems)
            {
                _comboBoxOptions.Add(p);
            }

            LoadManagementUnitsAsync();

            this.PropertyChanged += ManagementUnitModel_PropertyChanged;   
        }

        private void ManagementUnitModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine("combo changed");

            LoadManagementUnitsAsync();
        }

        private async Task LoadManagementUnitsAsync()
        {
            int applicationId = 0;

            Int32.TryParse(SelectedComboBoxOption.ID, out applicationId);
            
            if (applicationId == 99)
            {
                var items1 = await _managementUnitStore.GetManagementUnitLookupData();

                _managementUnits.ReplaceRange(items1);
            }
            else
            {
                var items1 = await _managementUnitStore.GetManagementUnitLookupData(applicationId);

                _managementUnits.ReplaceRange(items1);
            }

        }
        
        public ApplicationDto SelectedComboBoxOption
        {
            get
            {

                if (_SelectedComboBoxOption != null)
                    return _SelectedComboBoxOption;
                else
                    return _comboBoxOptions[0];
            }
            set
            {
                if (_SelectedComboBoxOption != value)
                {
                    _SelectedComboBoxOption = value;
                    RaisePropertyChanged("SelectedComboBoxOption");
                }
            }
        }

        public int SelectedItem { get; set; }

        void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void HandleMessage(EdMessage message)
        {
        //    throw new NotImplementedException();
        }
    }
}