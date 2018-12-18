using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using NewRC.classes;

namespace NewRC.db
{
    public class dbHelper
    {
        private SqlConnection connection;
        public SqlConnection getConn()
        {
            return connection;
        }
        
        public bool openDb()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename = D:\Univer\Семестр 5\Профессиональная практика программной инженерии\projects\NewRC\NewRC\MyDb.mdf; Integrated Security = True");
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public void close()
        {
            connection.Close();
        }

        public List<string> getListCars() 
        {
            List<string> list = new List<string>();
            string id;
            using (SqlCommand command = new SqlCommand("SELECT idCar FROM [Car]", connection))
            {

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    id = (string)reader.GetValue(0);
                    list.Add(id);
                }
                reader.Close();
                
            }
            return list;
        }

       

        public User authorisation(string username, string password, User user)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE login = @user AND password = @pass", connection))
            {
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@pass", password);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    user = getUserInfo(reader);
                    reader.Close();
                    return user;
                } 
                reader.Close();
                return null;
            }
        }

        private User getUserInfo(SqlDataReader reader)
        {
            User user = new User();
            user.id = (int)reader.GetValue(0);
            user.login = reader.GetString(1);
            user.password = reader.GetString(2);
            return user;
        }

        public bool registration(string username, string password)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE login = @u", connection)) // проверка на существование юзера с таким мылом
            {
                command.Parameters.AddWithValue("@u", username);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {                    
                    reader.Close();
                    return false;
                }
                reader.Close();
            }

            using (SqlCommand command = new SqlCommand("INSERT INTO [User] VALUES (@login, @password)", connection)) // добавление юзера
            {
                command.Parameters.AddWithValue("@login", username);
                command.Parameters.AddWithValue("@password", password);

                if (command.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        public bool findCar(string brand, List<Car> cars)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [Car] WHERE brand = @b", connection))
            {
                command.Parameters.AddWithValue("@b", brand);
                SqlDataReader reader = command.ExecuteReader();
                Car car;
                while (reader.Read())
                {
                    car = new Car();
                    car.id = (string)reader.GetValue(0);
                    car.brand = (string)reader.GetValue(1);
                    car.model = (string)reader.GetValue(2);
                    car.price = (int)reader.GetValue(3);
                    car.location = (string)reader.GetValue(4);
                    //Console.Write(car.id + " " + car.brand + " " + car.model + " " + car.price + " " + car.location + "\n");
                    cars.Add(car);
                }
                reader.Close();
                return true;
            }
        }

        public Car findCar(string idCar)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [Car] WHERE idCar = @idCar", connection))
            {
                command.Parameters.AddWithValue("@idCar", idCar);
                SqlDataReader reader = command.ExecuteReader();
                Car car = null;
                while (reader.Read())
                {
                    car = new Car();
                    car.id = (string)reader.GetValue(0);
                    car.brand = (string)reader.GetValue(1);
                    car.model = (string)reader.GetValue(2);
                    car.price = (int)reader.GetValue(3);
                    car.location = (string)reader.GetValue(4);
                }
                reader.Close();
                return car;
            }
        }

        public void insertCar(string id, string brand, string model, int price, string location, Car car)
        {


            using (SqlCommand command = new SqlCommand("INSERT INTO [Car] VALUES (@id, @brand, @model, @price, @location)", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@location", location);
                command.ExecuteNonQuery();
            }

        }

        public bool updateCar(string id1, string brand1, string model1, int price1, string location1)
        {

            using (SqlCommand command1 = new SqlCommand("UPDATE [Car] SET brand = @brand, model = @model, price = @price, location = @location WHERE idCar = @id", connection))
            {
                command1.Parameters.AddWithValue("@id", id1);
                command1.Parameters.AddWithValue("@brand", brand1);
                command1.Parameters.AddWithValue("@model", model1);
                command1.Parameters.AddWithValue("@price", price1);
                command1.Parameters.AddWithValue("@location", location1);
                command1.ExecuteNonQuery();
                if (command1.ExecuteNonQuery() == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public Car selectCar(string id)
        {
            Car car = new Car();
            using (SqlCommand command = new SqlCommand("SELECT * FROM [Car] WHERE idCar = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    car.id = (string)reader.GetValue(0);
                    car.brand = (string)reader.GetValue(1);
                    car.model = (string)reader.GetValue(2);
                    car.price = (int)reader.GetValue(3);
                    car.location = (string)reader.GetValue(4);

                }
                //if (command.ExecuteNonQuery() == 0)
                //{
                //  return null;
                //}
                reader.Close();
            }
            return car;
        }

        public bool deleteCar(string carNum)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM [Car] WHERE idCar = @idCar", connection))
            {
                command.Parameters.AddWithValue("@idCar", carNum);

                if (command.ExecuteNonQuery() == 0)
                {
                    //Console.Write("\nCar hasn't removed!\n");
                    return false;
                }
                else
                {
                    //Console.Write("\nCar has been removed!\n");
                    return true;
                }
            }
        }

        public Client addClient(string passport, string fullName, string phone)
        {
            Client client = new Client(passport, fullName, phone);
            using (SqlCommand command = new SqlCommand("INSERT INTO [Client] VALUES (@passport, @fullName, @phone)", connection))
            {
                command.Parameters.AddWithValue("@passport", passport);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@phone", phone);
                if (command.ExecuteNonQuery() == 0)
                    return null;
            }
            return client;
        }

        public Client selectClient(string id)
        {
            Client client = new Client();
            using (SqlCommand command = new SqlCommand("SELECT * FROM [Client] WHERE passport = @passport", connection))
            {

                command.Parameters.AddWithValue("@passport", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    client.passport = (string)reader.GetValue(0);
                    client.name = (string)reader.GetValue(1);
                    client.phone = (string)reader.GetValue(2);

                    //Console.Write(client.passport + " " + client.name + " " + client.phone + "\n");
                }
                //if (command.ExecuteNonQuery() == 0)
                //{
                //    return false;
                //}
                reader.Close();
            }
            return client;
        }

        public bool createRent(string passportClient, string idCar, User user, string from, string to, int duration)
        {
            Car car = selectCar(idCar);
            Client client = selectClient(passportClient);
            Rent rent = new Rent(client, car, duration, user, from, to);
            using (SqlCommand command = new SqlCommand("INSERT INTO [Rent] VALUES (@client, @car, @manager, @duration, @from, @to)", connection))
            {

                command.Parameters.AddWithValue("@client", client.passport);
                command.Parameters.AddWithValue("@car", car.id);
                command.Parameters.AddWithValue("@manager", user.id);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@from", from);
                command.Parameters.AddWithValue("@to", to);
                if (command.ExecuteNonQuery() == 0)
                {
                    //Console.Write("\nRent hasn't removed!\n");
                    return false;
                }
                else
                {
                    //Console.Write("\nRent has been removed!\n");
                    return true;
                }
                
            }

        }

        public bool deleteRent(int rentId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM [Rent] WHERE idRent = @idRent", connection))
            {
                command.Parameters.AddWithValue("@idRent", rentId);

                if (command.ExecuteNonQuery() == 0)
                {
                    //Console.Write("\nRent hasn't removed!\n");
                    return false;
                }
                else
                {
                    //Console.Write("\nRent has been removed!\n");
                    return true;
                }
            }
        }

        public bool changeCarLocation(string idCar, string location)
        {
            using (SqlCommand command = new SqlCommand(
                    "UPDATE [Car] SET location = @location WHERE idCar = @idCar", connection))
            {
                command.Parameters.AddWithValue("@idCar", idCar);
                command.Parameters.AddWithValue("@location", location);
                if (command.ExecuteNonQuery() == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool changeClientDataPhone(string passport, string phone)
        {
            using (SqlCommand command = new SqlCommand("UPDATE [Client] SET phone = @phone WHERE passport = @passport", connection))
            {
                command.Parameters.AddWithValue("@passport", passport);
                command.Parameters.AddWithValue("@phone", phone);
                if (command.ExecuteNonQuery() == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
