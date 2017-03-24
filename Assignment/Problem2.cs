//Sara Silva
//Student number: 1669329

/**Write a C# program as a console application that allows a user to input any no of positive integers less than 1001.
When the user enters any number outside the given range, the program displays the following:
a)No of integers entered. 
b)Sum of integers entered.
c)Average of integers entered (Average must be a real number formatted to display 2 decimal places).
d)Highest and lowest numbers entered.**/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Problem2
    {
        static void Main() {

            //declaring variables
            int positiveInteger, numberOfIntegers, sumOfIntegers, highestInteger, lowestInteger;
            double averageOfIntegers;

            //initializing variables outside the loop
            numberOfIntegers = 0;
            sumOfIntegers = 0;
            highestInteger = 0;
            lowestInteger = 0;

            // Asking user to keep on entering whole numbers as long as they are positive and less than 1001.
            // Using a do while loop since the message will be displayed to the user at least once.
            do
            {

                // continue asking user to enter whole numbers less than 1001
                Console.Write("Please enter a positive whole number less than 1001: ");
                positiveInteger = int.Parse(Console.ReadLine());

                if (positiveInteger > 0 && positiveInteger < 1001)
                {
                    //keeping track of number of integers entered
                    numberOfIntegers++;

                    //keeping track of sum of integers entered
                    sumOfIntegers += positiveInteger;
                }
                //keeping track of the highest integer
                if (highestInteger < positiveInteger && positiveInteger < 1001)
                    highestInteger = positiveInteger;

                //keeping track of the lowest integer
                if (lowestInteger > positiveInteger||lowestInteger == 0)
                    lowestInteger = positiveInteger;
            } while (positiveInteger > 0 && positiveInteger < 1001);

            //Calculating average of integers after the user exits the loop
            averageOfIntegers = (double)sumOfIntegers / numberOfIntegers;
            if (double.IsNaN(averageOfIntegers)) averageOfIntegers = 0;

            //Displaying accumulated information to user
            Console.WriteLine("No of integers entered: {0}", numberOfIntegers);
            Console.WriteLine("Sum of integers entered: {0}", sumOfIntegers);
            Console.WriteLine("Average of integers entered {0:.##}", averageOfIntegers);
            Console.WriteLine("Highest number: {0}", highestInteger);
            Console.WriteLine("Lowest number entered: {0}", lowestInteger);

            Console.Read();
          
        }
    }
}
