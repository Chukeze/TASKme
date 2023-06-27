using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMe.Stores;

namespace TaskMe.ViewModels
{
    /// <summary>
    /// The main view model for the application.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        /// <summary>
        /// Gets the current modal view model.
        /// </summary>
        public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;

        /// <summary>
        /// Gets a value indicating whether a modal is open.
        /// </summary>
        public bool IsModalOpen => _modalNavigationStore.IsOpen;

        /// <summary>
        /// Gets the container view model.
        /// </summary>
        public TaskMeContainerViewModel ContainerViewModel { get;}

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// <param name="modalNavigationStore">The modal navigation store.</param>
        /// <param name="containerViewModel">The container view model.</param>
        public MainViewModel(ModalNavigationStore modalNavigationStore, TaskMeContainerViewModel containerViewModel)
        {
            _modalNavigationStore = modalNavigationStore ?? throw new ArgumentNullException(nameof(modalNavigationStore));
            ContainerViewModel = containerViewModel;

            _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentViewModelChanged;


        }
        protected override void Dispose()
        {
            _modalNavigationStore.CurrentViewModelChanged -= ModalNavigationStore_CurrentViewModelChanged;
            base.Dispose();
        }
        private void ModalNavigationStore_CurrentViewModelChanged()
        { 
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
            
        }
    }
}
