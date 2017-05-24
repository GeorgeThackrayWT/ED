using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;
using SQLite;

namespace EDCORE.ViewModel
{
    public interface ITreePlantingModel : INotifyPropertyChanged
    {
        ObservableCollection<TreePlantingDto> TreePlantings { get; }
    }


    public class TreePlantingModel : ViewModelBase, ITreePlantingModel
    {
        private readonly ITestDataDal _idal;

        public ObservableCollection<TreePlantingDto> TreePlantings => _idal.TreePlantingList;

        public TreePlantingModel(ITestDataDal idal)
        {
            _idal = idal;
        }

        
    }
}