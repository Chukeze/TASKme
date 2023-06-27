using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.Stores;

namespace TaskMe.Commands
{
    /// <summary>
    /// Command for submitting edited form information.
    /// </summary>
    public class SubmitEditedFormInfoCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public SubmitEditedFormInfoCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            //ToDo: Create logic to Perform CRUD operations for submitting edited form

            _modalNavigationStore.Close();
        }
    }
}
