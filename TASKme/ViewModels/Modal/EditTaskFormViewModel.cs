using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskMe.Commands;
using TaskMe.Models;
using TaskMe.Stores;

namespace TaskMe.ViewModels.Modal
{
    /// <summary>
    /// The view model for the edit task form modal.
    /// </summary>
    public class EditTaskFormViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets the form details view model.
        /// </summary>
        public FormDetailsViewModel FormDetails { get; }

        /// <summary>
        /// Initializes a new instance of the EditTaskFormViewModel class.
        /// </summary>
        /// <param name="task">The task to edit.</param>
        /// <param name="modalNavigationStore">The modal navigation store.</param>
        public EditTaskFormViewModel(TaskViewer task, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new SubmitEditedFormInfoCommand(modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            FormDetails = new FormDetailsViewModel(null, cancelCommand)
            {
                TaskName = task.TaskName,
                TaskDescription = task.TaskDescription,
                TaskType = task.TaskType,
                IsCompleted = task.IsCompleted,
            };
        }
    }
}
