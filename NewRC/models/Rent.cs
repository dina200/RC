using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewRC.classes
{
    public class Rent
    {
        public Client client { get; set; }
        public Car car { get; set; }
        public int duration { get; set; }
        public User user { get; set; }
        public string from { get; set; }
        public string to { get; set; }

        public Rent(Client client, Car car, int duration, User user, string from, string to)
        {
            this.client = client;
            this.car = car;
            this.duration = duration;
            this.user = user;
            this.from = from;
            this.to = to;
        }

        
    }
}
