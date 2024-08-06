using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemRecreation.Model;

namespace VotingSystemRecreation.ViewModels
{
    internal class ViewCandidateViewModel : ViewModelBase
    {
       public ObservableCollection<Item> Items { get; set; }

        public ViewCandidateViewModel()
        {
            Items = new ObservableCollection<Item>(); 
            Items.Add(new Item
            {
                std_first_name = "JV",
                std_surname = "Medes",
                std_number = "20191656",
                std_password = "Password",
                std_username = "username",
            });
            Items.Add(new Item
            {
                std_first_name = "Test",
                std_surname = "Tester",
                std_number = "xxxxx",
                std_password = "1234",
                std_username = "5678",
            });
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
                OnPropertyChanged();
            }
        }
    }
}
