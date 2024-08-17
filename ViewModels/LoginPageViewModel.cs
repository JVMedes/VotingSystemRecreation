using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VotingSystemRecreation.Commands;
using VotingSystemRecreation.Stores;

namespace VotingSystemRecreation.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public ICommand LogInBtnCommand { get; }

        public LoginPageViewModel(NavigationStore _navigationStore, Func<LandingPageViewModel> createLandingPageViewModel) 
        {
            NavigationStore navigationStore = null;
            LogInBtnCommand = new NavigateCommand(_navigationStore, createLandingPageViewModel);
        }

    }
}
