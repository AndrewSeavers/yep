using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pizzas do you want? "); //Asks the user how many pizzas they would like to eat
            int answer = int.Parse(Console.ReadLine());

            for (int i = 0; i < answer; i++) //Loops the following for the number of times that you wanted pizzas
            {
                Console.WriteLine("Eat pizza number " + (i + 1)); //Concatinates the number of the pizza with the string before it
            }
            Console.ReadLine();
        }
    }
}
