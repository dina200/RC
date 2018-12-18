using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewRC.classes
{
    public class Car
    {
        public string id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        public string location { get; set; }

        public Car(Car car)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.location = location;
        }

        public Car() {}

    }
}
