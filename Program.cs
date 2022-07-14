// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlClient;

namespace School 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Creating a School...");

            Student st1 = new Student("Ellery", "ellery@gmail.com", "(123)456-7890", "1500 Pennsylvania Ave", "The White House", "Washington", "DC", "20500", 25, 30);
            Student st2 = new Student("Derick", "Derick@outlook.com", "(987)654-3210", "1600 Pennsylvania Ave", "The White House", "Washington", "DC", "20500", 24, 5);

            Teacher t1 = new Teacher("Eunice", "Eunice@hotmail.com", "(567)432-9012", "1700 Pennsylvania Ave", "", "Washington", "DC", "20500", 27, "Math", "Room 1", true, 100000, "Math", "Physics");
            Course c1 = new Course("Math", "Mathematics", "B5-103", DateTime.Now, 3);

            Console.WriteLine("School created!");

            //your connection string has all the details needed to connect to a database
            string connectionString = "Server=tcp:myfirstdatabase-grozdanov.database.windows.net,1433;Initial Catalog=MyFirstSQL;Persist Security Info=False;User ID=grozdanovlogin;Password=Packers!27;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            SqlConnection connection = new SqlConnection(connectionString);
        }
    }
}
