using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input a number & all odd numbers are displayed less than the input to 0
            //declaration
            string UserInput = ""; //input
            int number; //variable to hold a number
            int sum = 0; //variable to hold sum value
            Console.WriteLine("Input number"); //ask user to input a number
            number = Convert.ToInt32(Console.ReadLine()); //convert to integer 
            for (int i = 1; i < number; i += 2) //loop to run through all odd numbers
            {
                Console.WriteLine(i); //list numbers

                sum = sum + i; //sum of the digits calculation

              
            }

            Console.WriteLine("Sum=" + sum); //display sum
            Console.ReadLine(); //pause screen for user to view
        }
    }

}
 