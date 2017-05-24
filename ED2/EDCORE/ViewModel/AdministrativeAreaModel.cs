using System.ComponentModel;
using EDCORE.Helpers;
using SQLite;

namespace EDCORE.ViewModel
{

    public interface IAdministrativeAreaModel : INotifyPropertyChanged
    {

    }

    public class AdministrativeAreaModel : BindableBase, IAdministrativeAreaModel
    {
        private ITestDataDal _idal;

        public AdministrativeAreaModel(ITestDataDal idTestDataDal)
        {
            _idal = idTestDataDal;
        }


    }
}