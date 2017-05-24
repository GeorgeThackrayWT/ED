using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;
using SQLite;

namespace EDCORE.ViewModel
{

    public interface ISafetyModel : INotifyPropertyChanged
    {
        ObservableCollection<Safety> SafetyLists { get; }
    }

    public class SafetyModel : ViewModelBase, ISafetyModel
    {
        private readonly ITestDataDal _idal;

        public ObservableCollection<Safety> SafetyLists => _idal.SafetyList;

        public SafetyModel(ITestDataDal iTestDataDal)
        {
            _idal = iTestDataDal;
        }

        
    }
}