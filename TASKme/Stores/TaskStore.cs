using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.Models;

namespace TaskMe.Stores
{
    /// <summary>
    /// The task store responsible for managing tasks.
    /// </summary>
    public class TaskStore
    {
        /// <summary>
        /// Event raised when a task is added.
        /// </summary>
        public event Action<TaskViewer> TaskAdded;

        /// <summary>
        /// Adds a task to the task store.
        /// </summary>
        /// <param name="taskdata">The task data to add.</param>
        public async Task Add(TaskViewer taskdata)
        {
            TaskAdded?.Invoke(taskdata);
        }
    }
}
