using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TaskMe.Stores;
using TaskMe.ViewModels;

namespace TaskMe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedTaskStore _selectedTaskStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TaskStore _taskStore;

        public App()
        {
            // Initialize required stores
            _selectedTaskStore = new SelectedTaskStore();
            _modalNavigationStore = new ModalNavigationStore();
            _taskStore = new TaskStore();
        }

        /// <summary>
        /// Overrides the OnStartup method to initialize the application on startup.
        /// </summary>
        /// <param name="e">The <see cref="StartupEventArgs"/> instance containing the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            TaskMeContainerViewModel TaskView = new TaskMeContainerViewModel(_selectedTaskStore, _modalNavigationStore, _taskStore);
            
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, TaskView)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
