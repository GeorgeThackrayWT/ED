using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;
using SQLite;

namespace EDCORE.ViewModel
{
    public interface IManagementPlanModel : INotifyPropertyChanged
    {
        ObservableCollection<ManagementPlan> ManagementPlans { get; }
    }


    public class ManagementPlanModel : ViewModelBase, IManagementPlanModel
    {
        private ITestDataDal _iTestDataDal;
        
        public ManagementPlanModel(ITestDataDal iTestDataDal)
        {
            _iTestDataDal = iTestDataDal;
        }

        public ObservableCollection<ManagementPlan> ManagementPlans => _iTestDataDal.ManagementPlans;
    }
}