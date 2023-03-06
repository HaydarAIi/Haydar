using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(plus(9564,6785,4455));

            Console.WriteLine(multiple(4,5,6,7,8,9));
            Console.ReadKey(true);



        }
        static int plus(params int[] sayilar)
        {
            //It is used to pass a variable number of arguments (parameters) to a method.
            int toplam = 0;
            foreach(var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }
        static int multiple(params int[] nums)
        {
            int result = 1;
            foreach(var item in nums)
            {
                result = result * item;
            }
            return result;  
        }
    }
}
