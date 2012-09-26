using System.Collections.Generic;
using RebtelBlack.DomainModel;

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

        public List<EndpointIdentity> Endpoints
        {
            get { return _endpoints; }
        }

        public List<object> History
        {
            get
            {
                return new List<object>
                {
                    new TextMessage(),
                    new TextMessage(),
                    new TextMessage(),
                    new Call()
                }; 
            }
        }
    }
}
