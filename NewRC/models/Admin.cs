using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewRC.db;
namespace NewRC.classes
{
    public class Admin : User
    {
        public void insertCar(dbHelper db)
        {
            Console.Write("Add new car:\n");
            Console.Write("id:\n");
            string id = Console.ReadLine();
            Console.Write("brand:\n");
            string brand = Console.ReadLine();
            Console.Write("model:\n");
            string model = Console.ReadLine();
            Console.Write("price:\n");
            int price;
            try
            {
                price = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                price = 100;
            }
            Console.Write("location:\n");
            string location = Console.ReadLine();
            Car car = new Car();
            db.insertCar(id, brand, model, price, location, car);
            Console.Read();
            Console.Read();
        }

        public void deleteCar(dbHelper db)
        {
            Console.Write("Car's brand for removing:\n");
            string brand = Console.ReadLine();
            db.deleteCar(brand);
            Console.Read();
            Console.Read();
        }

        public void changeCar(dbHelper db)
        {
            Console.Write("Enter idCar for change:\n");
            string id = Console.ReadLine();
            db.selectCar(id);
            Console.Write("Enter new brand:\n");
            string brand = Console.ReadLine();
            Console.Write("Enter new model:\n");
            string model = Console.ReadLine();
            Console.Write("Enter new price:\n");
            int price;
            try
            {
                price = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                price = 100;
            } 
            Console.Write("Enter new location:\n");
            string location = Console.ReadLine();
            db.updateCar(id, brand, model, price, location);
            db.selectCar(id);
            Console.Read();
            Console.Read();
        }

    }
}
