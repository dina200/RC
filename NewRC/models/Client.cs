using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewRC.classes
{
    public class Client
    {
        public string passport { get; set; }
        public string name { get; set; }        
        public string phone { get; set; }

        public Client(string name, string passport, string phone)
        {
            this.name = name;
            this.passport = passport;
            this.phone = phone;
        }

        public Client() { }

    }
}
