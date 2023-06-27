using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.ViewModels;

namespace TaskMe.Stores
{
    /// <summary>
    /// The store for managing the modal navigation.
    /// </summary>
    public class ModalNavigationStore 
    {

        private ViewModelBase _currentViewModel;

        /// <summary>
        /// Gets or sets the current view model.
        /// </summary>
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set 
            {
                if(_currentViewModel != value)
                {
                    DisposeCurrentViewModel();
                    _currentViewModel = value;
                    CurrentViewModelChanged?.Invoke();                 
                }

            }
        }


        /// <summary>
        /// Gets a value indicating whether the modal is open.
        /// </summary>
        public bool IsOpen => CurrentViewModel != null;

        /// <summary>
        /// Event raised when the current view model changes.
        /// </summary>
        public event Action CurrentViewModelChanged;

        /// <summary>
        /// Closes the modal.
        /// </summary>
        public void Close()
        {
            CurrentViewModel = null;
        }

        private void DisposeCurrentViewModel()
        {
            if(_currentViewModel != null && _currentViewModel is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }     
 
    }
}
