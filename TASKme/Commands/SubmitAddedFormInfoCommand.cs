using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.Stores;

namespace TaskMe.Commands
{
    /// <summary>
    /// Command for submitting added form information.
    /// </summary>
    public class SubmitAddedFormInfoCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public SubmitAddedFormInfoCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            //ToDO: Create Logic to Perform CRUD operations for submitting form so that data can be added  and then retrievied in order to display the new task added

            _modalNavigationStore.Close();
        }
    }
}
