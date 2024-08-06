using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VotingSystemRecreation.ViewModels
{
    public class LandingPageViewModel : ViewModelBase 
    {
        public ICommand ToVotingPage {  get; }
        public ICommand ToViewCandidate { get; }
    }
}
