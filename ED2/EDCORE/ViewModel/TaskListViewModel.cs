using System;
using System.Diagnostics;
using System.Windows.Input;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using MvvmHelpers;
using Task = System.Threading.Tasks.Task;

namespace EDCORE.ViewModel
{
    public interface ITaskListViewModel : IBase 
    {
        ObservableRangeCollection<DataObjects.SimpleTaskDTO> SimpleTasks { get; }

        DateOption SearchRange { get; set; }

        int SelectedManagementUnit { get; set; }

        ICommand LoadTasksCommand { get; }
      
        Task ExecuteLoadPastTasksCommandAsync();
        
    }

    public class TaskListViewModel : BaseViewModel, ITaskListViewModel, ISubscriber<EdMessage>
    {
        private ICommand _loadTasksCommand;

        private readonly ITaskStore _taskStore;
  
        public ObservableRangeCollection<SimpleTaskDTO> SimpleTasks { get; } = new ObservableRangeCollection<SimpleTaskDTO>();

        private IMyEventAggregator _myEventAggregator;

        public TaskListViewModel()
        {

        }

        public TaskListViewModel(ITaskStore iTaskStore, IMyEventAggregator iMyEventAggregator)
        {
            _taskStore = iTaskStore;
            _myEventAggregator = iMyEventAggregator;
             
            _myEventAggregator.Subscribe(this);

            SearchRange = DateOption.Today;
            SelectedManagementUnit = 0;

            ExecuteLoadPastTasksCommandAsync();
            
        }
 
        public ICommand LoadTasksCommand =>
           _loadTasksCommand ??
           (_loadTasksCommand = new RelayCommand(async () => await ExecuteLoadPastTasksCommandAsync()));

        public DateOption SearchRange { get; set; }

        public int SelectedManagementUnit { get; set; }



        public async Task ExecuteLoadPastTasksCommandAsync()
        {
            Debug.WriteLine("ExecuteLoadPastTasksCommandAsync");

            try
            {
                var items = await _taskStore.GetTasks(new DateRangeFilter {
                    DateRange = this.SearchRange,                    
                },
                this.SelectedManagementUnit
                );
                SimpleTasks.ReplaceRange(items);                                       
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
          
        }



        public void HandleMessage(EdMessage message)
        {
             
            switch (message.EdEvent)
            {
                case EdEvent.TaskFilterChanged:

                    switch (message.Data.ToString())
                    {
                        case "taskall":
                            SearchRange = DateOption.All;
                            break;
                        case "taskyear":
                            SearchRange = DateOption.Year;
                            break;
                        case "taskmonth":
                            SearchRange = DateOption.Month;
                            break;
                        case "taskweek":
                            SearchRange = DateOption.Week;
                            break;
                        case "taskstoday":
                            SearchRange = DateOption.Today;
                            break;
                    }
                    ExecuteLoadPastTasksCommandAsync();
                    break;
                
                case EdEvent.ManagementUnitChanged:
                    int managementUnitId = (int)message.Data;
                    SelectedManagementUnit = managementUnitId;
                    ExecuteLoadPastTasksCommandAsync();
                    break;

            }

        }
    }
}
