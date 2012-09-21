using System.Collections.Generic;
namespace RebtelBlack
{
    class ContactViewModel: ViewModel
    {
        private string _name;
        private List<EndpointIdentity> _endpoints;

        public ContactViewModel(string name, string endpoint)
        {
            _name = name;
            _endpoints = new List<EndpointIdentity>();
            _endpoints.Add(new EndpointIdentity(endpoint));
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }

        }
    }
}
