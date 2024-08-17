using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VotingSystemRecreation.Stores;
using VotingSystemRecreation.ViewModels;
using VotingSystemRecreation.Views;

namespace VotingSystemRecreation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateLandingPageViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private LandingPageViewModel CreateLandingPageViewModel()
        {
            return new LandingPageViewModel(_navigationStore, CreateLoginPageViewModel);
        }

        private LoginPageViewModel CreateLoginPageViewModel()
        {
            return new LoginPageViewModel(_navigationStore, CreateLandingPageViewModel);
        }
    }
}
