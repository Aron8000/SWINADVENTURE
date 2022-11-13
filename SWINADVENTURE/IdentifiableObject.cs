using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SWINADVENTURE
{
        public  class IdentifiableObject 
    {
        private readonly List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] idents)
        {
            foreach (string ident in idents)
            {
                _identifiers.Add(ident);
            }
        }
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }
        public string FirstId
        {

            get
            {
                return _identifiers[0];
                //return identifier;
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id);
        }
    }
}