using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskMe.Stores;
using TaskMe.ViewModels.Modal;

namespace TaskMe.Commands
{
    /// <summary>
    /// Command for opening a modal on adding a task.
    /// </summary>
    public class OpenModalOnAdd : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly SelectedTaskStore _selectedTaskStore;

        public OpenModalOnAdd( SelectedTaskStore selectedTaskStore,ModalNavigationStore modalNavigationStore, TaskStore taskStore)
        {
            _modalNavigationStore = modalNavigationStore;
            _selectedTaskStore = selectedTaskStore;
        }

         public override void Execute(object parameter)
        {
            AddTaskFormViewModel addTaskForm = new AddTaskFormViewModel(_selectedTaskStore,_modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = addTaskForm;
        }
    }
}
