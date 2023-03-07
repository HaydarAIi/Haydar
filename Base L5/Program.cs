
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_L5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BaseClass abc = new BaseClass();
           DerivedClass derived = new DerivedClass();
            Console.ReadKey();

        }
    }
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base class constructor.");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {
            Console.WriteLine("Derived class constructor.");
        }
    }
}
