using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskMe.Models;

namespace TaskMe.ViewModels.TaskList
{
    /// <summary>
    /// The view model for task items in the task list.
    /// </summary>
    public class TaskItems : ViewModelBase
    {
        /// <summary>
        /// Gets the task viewer associated with the task item.
        /// </summary>
        public TaskViewer TaskViewer { get; }

        /// <summary>
        /// Gets the task name.
        /// </summary>
        public string TaskName => TaskViewer.TaskName;


        /// <summary>
        /// Gets the command to add a task.
        /// </summary>
        public ICommand AddTaskCommand { get; }
        /// <summary>
        /// Gets the command to remove a task.
        /// </summary>
        public ICommand RemoveTaskCommand { get; }
        /// <summary>
        /// Gets the command to edit a task.
        /// </summary>
        public ICommand EditTaskCommand { get; }

        /// <summary>
        /// Initializes a new instance of the TaskItems class.
        /// </summary>
        /// <param name="taskViewer">The task viewer.</param>
        /// <param name="editCommand">The command to edit the task.</param>
        public TaskItems(TaskViewer taskViewer, ICommand editCommand)
        {

            TaskViewer = taskViewer;
            EditTaskCommand = editCommand;
        }
    }
}
