using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMe.Models
{
    /// <summary>
    /// Represents the task model.
    /// </summary>
    /// <todo>
    /// 1. As the Data is scafolded refactor to where these are just read only
    /// 2. Consider DbContext using EntityFrameWork
    /// 3. Might require some factory function to accomplish.
    /// 4. Implement Crud
    /// </todo>
    public class TaskViewer
    {
        /// <summary>
        /// Gets the ID of the task.
        /// </summary>
        public int Id { get;}

        /// <summary>
        /// Gets the name of the task.
        /// </summary>
        public string TaskName { get;}

        /// <summary>
        /// Gets the description of the task.
        /// </summary>
        public string TaskDescription { get; }

        /// <summary>
        /// Gets a value indicating whether the task is completed.
        /// </summary>
        public bool IsCompleted { get;}

        /// <summary>
        /// Gets the type of the task.
        /// </summary>
        public string TaskType { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskViewer"/> class.
        /// </summary>
        /// <param name="id">The ID of the task.</param>
        /// <param name="taskName">The name of the task.</param>
        /// <param name="taskDescription">The description of the task.</param>
        /// <param name="isCompleted">A value indicating whether the task is completed.</param>
        /// <param name="taskType">The type of the task.</param>
        public TaskViewer(string id, string taskName, string taskDescription, bool isCompleted, string taskType)
        {
            Id = Id;
            TaskName = taskName;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
            TaskType = taskType;

        }
        
    }
}
