using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RebtelBlack
{
    class MainViewModel: ViewModel
    {
        private readonly ObservableCollection<ContactViewModel> _contacts = new ObservableCollection<ContactViewModel>();
        private ContactViewModel _selectedContact;
        private readonly RebtelUser _user = new RebtelUser();

        public MainViewModel()
        {
            _contacts.Add(new ContactViewModel("Pernilla Uhlin", "+46707889088"));
            _contacts.Add(new ContactViewModel("Anna Karlsson", "+461122334"));
        }

        public RebtelUser User
        {
            get { return _user; }
        }

        public ObservableCollection<ContactViewModel> Contacts
        {
            get { return _contacts; }
        }

        public ContactViewModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                RaisePropertyChanged("SelectedContact");
            }
        }

        public bool NetworkOperationInProgress
        {
            get { return true; }
        }
    }
}
