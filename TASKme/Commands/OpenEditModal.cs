using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.Models;
using TaskMe.Stores;
using TaskMe.ViewModels.Modal;

namespace TaskMe.Commands
{
    /// <summary>
    /// Command for opening the edit modal.
    /// </summary>
    public class OpenEditModal : CommandBase
    {

        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TaskViewer _taskData;

        public OpenEditModal( TaskViewer task, ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
            _taskData = task;

        }

        public override void Execute(object parameter)
        {
            EditTaskFormViewModel editTaskForm = new EditTaskFormViewModel(_taskData,_modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = editTaskForm;
        }
    }
}
