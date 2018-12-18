using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RC.db;

namespace RC.classes
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }


        public void rentCar(dbHelper db)
        {
            string passport = Console.ReadLine();
            string fullName = Console.ReadLine();
            string phone = Console.ReadLine();
            db.addClient(passport, fullName, phone);
            string carId = Console.ReadLine();
            int duration;
            try
            {
                duration = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                duration = 0;   
            }
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            db.createRent(passport, carId, this, from, to, duration);
        }

        public void findCar(dbHelper db)
        {
            Console.Write("Car's brand:\n");
            string brand = Console.ReadLine();
            List<Car> cars = new List<Car> { };
            db.findCar(brand, cars);
            Console.Read();
            Console.Read();
        }

        public void findCarById(dbHelper db)
        {
            Console.Write("Car's id:\n");
            string location = Console.ReadLine();            
            Car car = db.findCar(location);
            if (car != null)
            {
                Console.Write(car.id + " " + car.location + "\n");
            }
            else
            {
                Console.Write("Car doesn't exist\n");
            }

            Console.Read();
            Console.Read();
        }

        public void changeCarLocation(dbHelper db)
        {
            Console.Write("Car's number:\n");
            string num = Console.ReadLine();
            Console.Write("New car's location:\n");
            string loc = Console.ReadLine();
            db.changeCarLocation(num, loc);
            Console.Read();
            Console.Read();
        }
        
        public void deleteRent(dbHelper db){
            Console.Write("Rent's num:\n");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                db.deleteRent(num);
            }
            catch (Exception e)
            {
                Console.Write("Not corrct data:\n");
            }
            Console.Read();
            Console.Read();
        }


        public void changeClientPhone(dbHelper db)
        {
            Console.Write("Client's passport:\n");
            string id = Console.ReadLine();
            Console.Write("New phone:\n");
            string phone = Console.ReadLine();
            db.changeClientDataPhone(id, phone);
            Console.Read();
            Console.Read();
        }
    }

}
