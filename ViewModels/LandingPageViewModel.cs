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
    public class LandingPageViewModel : ViewModelBase 
    {
        public ICommand ToVotingPage {  get; }
        public ICommand ToViewCandidate { get; }

        public LandingPageViewModel(NavigationStore _navigationStore, Func<LoginPageViewModel> createLoginPageViewModel)
        {
            NavigationStore navigationStore = null;
            ToVotingPage = new NavigateCommand(_navigationStore, createLoginPageViewModel);
            ToViewCandidate = new NavigateCommand(_navigationStore, createLoginPageViewModel);
        }
    }
}
