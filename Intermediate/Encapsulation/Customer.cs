using System;

namespace Encapsulation
{
    public class Customer
    {
        private string _Name;   

        public string getDetails()
        {
            return _Name;
        }

        public void setDetails(string name)
        {
            this._Name = name;
        }
    }
}
