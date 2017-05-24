using System.ComponentModel;
using SQLite;

namespace EDCORE.ViewModel
{
    public interface IMapsModel : INotifyPropertyChanged
    {
         
    }

    public class MapsModel : ViewModelBase, IMapsModel
    {
        private readonly ITestDataDal _idal;

        public MapsModel(ITestDataDal iTestDataDal)
        {
            _idal = iTestDataDal;
        }

    }
}