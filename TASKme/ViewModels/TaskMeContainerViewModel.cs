using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskMe.Commands;
using TaskMe.Stores;
using TaskMe.ViewModels.TaskList;

namespace TaskMe.ViewModels
{
    /// <summary>
    /// The view model for the TaskMeContainerView.
    /// </summary>
    public class TaskMeContainerViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets the tasks list view model.
        /// </summary>
        public TasksListViewModel TasksListViewModel { get;}

        /// <summary>
        /// Gets the task details view model.
        /// </summary>
        public TaskDetailsViewModel TaskDetailsViewModel { get;}

        public ICommand RefreshViewCommand { get;}

        /// <summary>
        /// Gets the command to open the add task modal.
        /// </summary>
        public ICommand OpenAddTaskModal { get; }

        /// <summary>
        /// Initializes a new instance of the TaskMeContainerViewModel class.
        /// </summary>
        /// <param name="selectedTaskStore">The selected task store.</param>
        /// <param name="modalNavigationStore">The modal navigation store.</param>
        /// <param name="taskStore">The task store.</param>
        public TaskMeContainerViewModel(SelectedTaskStore selectedTaskStore, ModalNavigationStore modalNavigationStore, TaskStore taskStore)
        {
            TaskDetailsViewModel = new TaskDetailsViewModel(selectedTaskStore);
            TasksListViewModel = new TasksListViewModel(selectedTaskStore, modalNavigationStore, taskStore);

            OpenAddTaskModal = new OpenModalOnAdd(selectedTaskStore, modalNavigationStore, taskStore);

        }
    }
}
