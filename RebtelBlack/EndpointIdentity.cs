using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RebtelBlack
{
    class EndpointIdentity
    {
        private readonly string _endpoint;

        public EndpointIdentity(string endpoint)
        {
            _endpoint = endpoint;
        }

        public string Identity { get { return "Call " + _endpoint; } }
    }
}
