using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskMe.Commands;
using TaskMe.Stores;

namespace TaskMe.ViewModels.Modal
{
    /// <summary>
    /// The view model for the add task form modal.
    /// </summary>
    public class AddTaskFormViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets the form details view model.
        /// </summary>
        public FormDetailsViewModel FormDetails { get; }

        /// <summary>
        /// Initializes a new instance of the AddTaskFormViewModel class.
        /// </summary>
        /// <param name="selectedTaskStore">The selected task store.</param>
        /// <param name="modalNavigationStore">The modal navigation store.</param>
        public AddTaskFormViewModel(SelectedTaskStore selectedTaskStore,ModalNavigationStore modalNavigationStore)
        {

            ICommand submitCommand = new SubmitAddedFormInfoCommand(modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            FormDetails = new FormDetailsViewModel(submitCommand,cancelCommand);

        }
    }
}
