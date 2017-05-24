//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using DataObjects.DTOS;
//using SQLite;


//namespace Test1.ViewModel
//{
//    public interface ITaskPageViewModel : INotifyPropertyChanged
//    {
//        ObservableCollection<Safety> Tasks { get; }
//    }

//    public class TaskPageViewModel : ViewModelBase
//    {

//        private readonly IDal _idal;

//        public TaskPageViewModel(IDal idal)
//        {
//            _idal = idal;
//        }

//        public ObservableCollection<TaskDto> Tasks => _idal.Tasks;
//    }
//}
