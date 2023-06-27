using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMe.Commands
{
    /// <summary>
    /// Base class for asynchronous commands.
    /// </summary>
    public abstract class AsyncCommandBase : CommandBase
    {
        public override async void Execute(object parameter)
        {
            //Eat the exception to avoid crashing here
            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception) { }
        }
        public abstract Task ExecuteAsync(object parameter);
    }
}
