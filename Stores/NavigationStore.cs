using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemRecreation.ViewModels;

namespace VotingSystemRecreation.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _viewModel;
        public ViewModelBase CurrentViewModel 
        { 
            get => _viewModel;
            set
            {
                _viewModel = value;
                OnCurrentViewModelChanged();
            }
        }
        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
