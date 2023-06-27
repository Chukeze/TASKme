using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.Models;
using TaskMe.Stores;

namespace TaskMe.ViewModels.TaskList
{
    /// <summary>
    /// The view model for task details.
    /// </summary>
    public class TaskDetailsViewModel : ViewModelBase
    {
        private readonly SelectedTaskStore _selectedTaskStore;
        /// <summary>
        /// Gets the selected task.
        /// </summary>
        private TaskViewer SelectedTask => _selectedTaskStore.SelectedTask; //helper property
        /// <summary>
        /// Gets a value indicating whether a task item is selected.
        /// </summary>
        public bool HasSelectedTaskItem => SelectedTask != null;
        /// <summary>
        /// Gets the task ID.
        /// </summary>
        public string TaskId { get;}
        /// <summary>
        /// Gets the task name.
        /// </summary>
        public string TaskName => SelectedTask?.TaskName; //optional change to avoid null pointer exception
        /// <summary>
        /// Gets the task description.
        /// </summary>
        public string TaskDescription => SelectedTask?.TaskDescription;
        /// <summary>
        /// Gets the task completion status.
        /// </summary>
        public string IsComplete => (SelectedTask?.IsCompleted ?? false) ? "Complete" : "Incomplete";
        /// <summary>
        /// Gets the task type.
        /// </summary>
        public string TaskType => SelectedTask?.TaskType;
        /// <summary>
        /// Initializes a new instance of the TaskDetailsViewModel class.
        /// </summary>
        /// <param name="selectedTaskStore">The selected task store.</param>
        public TaskDetailsViewModel(SelectedTaskStore selectedTaskStore)
        {
            _selectedTaskStore = selectedTaskStore;
            _selectedTaskStore.SelectedTaskViewerChanged += SelectedTaskViewer_SelectedTaskViewerChanged;
        }


        /***
         * For Maintainablitity and Scalabality reason although as of now the taskdetail lifecycle is equal to the duration of the application
         * However to allow for future potential change that might cause it lifecycle length to be different
         * a cleanup method is added.
         * Deeper explanation: Since the viewmodel subcribe to a global store and to avoid unnecessarily long LifeCycle for the viewmodel 
         * this cleanup method is used to handle potential future lifecycle issues. Thus, this is done to avoid Memory Leaked
         */
        /// <summary>
        /// Handles the cleanup of the view model.
        /// </summary>
        protected override void Dispose()
        {
            _selectedTaskStore.SelectedTaskViewerChanged -= SelectedTaskViewer_SelectedTaskViewerChanged;
            base.Dispose();
        }
        /// <summary>
        /// Handles the change in the selected task viewer.
        /// </summary>
        private void SelectedTaskViewer_SelectedTaskViewerChanged()
        {
            OnPropertyChanged(nameof(HasSelectedTaskItem));
            OnPropertyChanged(nameof(TaskName));
            OnPropertyChanged(nameof(TaskDescription));
            OnPropertyChanged(nameof(TaskType));
            OnPropertyChanged(nameof(IsComplete));
        }
    }
}
