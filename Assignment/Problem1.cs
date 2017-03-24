//Sara Silva
//Student number: 1669329

/**Write a C# program as a console application that asks the user to enter a username and a password. 
The program will then verify if the username and password in combination are valid or not. 
For the problem assume that the username is “DBSSaff” and the password is “dbs45ty”.**/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Problem1
    {
        static void Main(string[] args)
        {
            // declaring variables
            string username, password;

            // asking user for username
            Console.Write("Please enter username: ");
            username = Console.ReadLine();

            // asking user for password
            Console.Write("Please enter password: ");
            password = Console.ReadLine();

            // checking if username and password combination is correct

            if (username == "DBSStaff" && password == "dbs45ty")
            {
                Console.WriteLine("Welcome Staff to the DBS management system");
            }
            else {

                Console.WriteLine("Invalid Username or Password");
            }
            Console.ReadLine();
        }
    }
}
