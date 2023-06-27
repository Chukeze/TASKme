using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TaskMe.ViewModels.Menu
{
    /// <summary>
    /// The view model for the menu.
    /// </summary>
    /// <todo>
    /// 1. Allow On Click on a menu Item it retrieves the taskitem from database
    /// that match the menu item name based on a tasktype comparision
    /// Then populate the task listing screen(Middle Component) with the task
    /// </todo>
    public class MenuViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets the command to perform logout.
        /// </summary>
        /// <todo>
        /// 1. Create a profile or Account auth 
        /// 2. Allow login and logout functionalities
        /// </todo>
        public ICommand LogoutCommand { get; }
    }
}
