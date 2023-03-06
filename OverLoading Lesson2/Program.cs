using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2.5, 4.5));  
            Console.ReadKey(true);
        }
        public static int Add(int a, int b)//The first method takes two integers as arguments and returns their sum as an integer.
        {
            return a + b;
        }

        public static double Add(double a, double b)//The second method takes two doubles as arguments and returns their sum as a double.
        {
            return a + b;
        }
    }
}
//The two methods have the same name, but they have different parameter types.