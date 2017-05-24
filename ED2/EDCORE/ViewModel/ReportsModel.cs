using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;
using SQLite;

namespace EDCORE.ViewModel
{

    public interface IReportsModel : INotifyPropertyChanged
    {
        ObservableCollection<Report> Reports { get; }
    }
    public class ReportsModel : ViewModelBase, IReportsModel
    {
        private readonly ITestDataDal _idal;

        public ObservableCollection<Report> Reports => _idal.Reports;

        public ReportsModel(ITestDataDal iTestDataDal)
        {
            _idal = iTestDataDal;
        }

        
    }
}