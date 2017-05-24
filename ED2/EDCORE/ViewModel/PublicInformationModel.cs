using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;
using SQLite;

namespace EDCORE.ViewModel
{
    public interface IPublicInformationModel : INotifyPropertyChanged
    {
        ObservableCollection<PublicInformation> PublicProperties { get; }
    }

    public class PublicInformationModel : ViewModelBase, IPublicInformationModel
    {
       
        private readonly ITestDataDal _idal;

        public ObservableCollection<PublicInformation> PublicProperties => _idal.PubliocInformations;

        public PublicInformationModel(ITestDataDal iTestDataDal)
        {
            _idal = iTestDataDal;
        }


    }
}