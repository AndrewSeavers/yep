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
            // Asks the user how many pizzas they would like to eat
            Console.WriteLine("How many pizzas do you want? "); 
            int answer = int.Parse(Console.ReadLine());

            // Loops the following for the number of times that you wanted pizzas
            for (int i = 0; i < answer; i++ )
            {
                // Concatinates the number of the pizza with the string before it
                Console.WriteLine("Eat pizza number " + (i + 1)); 
            }

            for(int minutes = 16; minutes >=0; minutes--) {
                Console.WriteLine(minutes + " minutes left");
            }
            Console.ReadLine();
        }
    }
}
