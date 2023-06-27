using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskMe.Commands;
using TaskMe.Models;
using TaskMe.Stores;

namespace TaskMe.ViewModels.TaskList
{
    /// <summary>
    /// The view model for the tasks list.
    /// </summary>
    public class TasksListViewModel : ViewModelBase
    {
        //use Observale Collection due to auto update UI feature that OC has over List when an item is added/removed to it 
        private readonly ObservableCollection<TaskItems> _taskItems;
        private readonly SelectedTaskStore selectedTaskStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TaskStore _taskStore;

        /// <summary>
        /// Gets the task items.
        /// </summary>
        public IEnumerable<TaskItems> TaskItems => _taskItems;

        private TaskItems _selectedTaskItem;

        /// <summary>
        /// Gets or sets the selected task item.
        /// </summary>
        public TaskItems SelectedTaskItem
        {
            get
            {
                return _selectedTaskItem;
            } 
            set
            {
                _selectedTaskItem = value;
                OnPropertyChanged(nameof(SelectedTaskItem));
                selectedTaskStore.SelectedTask = _selectedTaskItem?.TaskViewer;

            } 
        }

        /// <summary>
        /// Initializes a new instance of the TasksListViewModel.
        /// </summary>
        /// <param name="selectedTaskStore">The selected task store.</param>
        /// <param name="modalNavigationStore">The modal navigation store.</param>
        /// <param name="taskStore">The task store.</param>
        /// <todo>
        /// 1. Finish Up TaskList to retrieve Task Directly From DataBase, and get rid of HardCoded Task
        /// </todo>
        /// 
        public TasksListViewModel(SelectedTaskStore _selectedTaskStore, ModalNavigationStore modalNavigationStore, TaskStore taskStore)
        {
            
            selectedTaskStore = _selectedTaskStore;
            _modalNavigationStore = modalNavigationStore;
            _taskStore = taskStore;
            _taskItems = new ObservableCollection<TaskItems>();
            

            _taskStore.TaskAdded += _taskStore_TaskAdded;


            AddTaskToData(new TaskViewer("123432","Jog","Take a 2 mile Jog around the neighborhood",false,"Personal"));
            AddTaskToData(new TaskViewer("123432", "Cook", "Cook Dinner", false, "Personal"));
            AddTaskToData(new TaskViewer("123432", "Gym", "Go To Gym and Do 20 min BTD", false, "Personal"));

        }

        protected override void Dispose()
        {
            _taskStore.TaskAdded -= _taskStore_TaskAdded;
            base.Dispose();
        }

        private void _taskStore_TaskAdded(TaskViewer data)
        {
            AddTaskToData(data);
        }

        private void AddTaskToData(TaskViewer taskData)
        {
            ICommand editCommand = new OpenEditModal(taskData, _modalNavigationStore);
            _taskItems.Add(new TaskItems(taskData, editCommand));
        }
    }
}
