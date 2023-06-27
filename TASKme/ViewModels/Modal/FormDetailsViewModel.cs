using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TaskMe.ViewModels.Modal
{
    /// <summary>
    /// The view model for the form details.
    /// </summary>
    public class FormDetailsViewModel : ViewModelBase
    {
        private string _taskname;
        public string TaskName
        {
            get { return _taskname; }
            set 
            { 
                _taskname = value; 
                OnPropertyChanged(nameof(TaskName));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }
        private string _taskdescription;
        public string TaskDescription
        {
            get { return _taskdescription; }
            set { _taskdescription = value; OnPropertyChanged(nameof(TaskDescription)); }
        }
        private bool _isCompleted;
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; OnPropertyChanged(nameof(IsCompleted)); }
        }
        private string _tasktype;



        public string TaskType
        {
            get { return _tasktype; }
            set { _ = value; OnPropertyChanged(nameof(TaskType)); }
        }

        /// <summary>
        /// Gets a value indicating whether the form can be submitted.
        /// </summary>
        public bool CanSubmit => string.IsNullOrEmpty(TaskName);

        /// <summary>
        /// Gets the submit command.
        /// </summary>
        public ICommand SubmitCommand {get;}

        /// <summary>
        /// Gets the cancel command.
        /// </summary>
        public ICommand CancelCommand { get; }

        /// <summary>
        /// Initializes a new instance of the FormDetailsViewModel class.
        /// </summary>
        /// <param name="submitCommand">The submit command.</param>
        /// <param name="cancelCommand">The cancel command.</param>
        public FormDetailsViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }



    }
}
