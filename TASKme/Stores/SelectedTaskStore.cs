using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.Models;

namespace TaskMe.Stores
{
    /// <summary>
    /// The store for managing the selected task.
    /// </summary>
    public class SelectedTaskStore
    {
        private TaskViewer _selectedTask;
        /// <summary>
        /// Gets or sets the selected task.
        /// </summary>
        public TaskViewer SelectedTask
        {
            get { return _selectedTask; }
            set 
            { 
                _selectedTask = value;
                SelectedTaskViewerChanged?.Invoke();
            }
        }
        /// <summary>
        /// Event raised when the selected task viewer changes.
        /// </summary>
        public event Action SelectedTaskViewerChanged;
    }
}
