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
            Console.WriteLine("How many pizzas do you want? ");
            int answer = int.Parse(Console.ReadLine());

            for (int i = 0; i < answer; i++)
            {
                Console.WriteLine("Eat pizza number " + (i + 1));
            }
            Console.ReadLine();
        }
    }
}
