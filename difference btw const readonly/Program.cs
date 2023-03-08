using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difference_btw_const_readonly_L7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int constValue = 5;
            Console.WriteLine("constValue: {0}", constValue);//you have to give value at first

            MyClass myClass = new MyClass();//you can give a value whenever you want
            Console.WriteLine("myClass.ReadOnlyValue: {0}", myClass.ReadOnlyValue);
        }
        class MyClass
        {
            public readonly int ReadOnlyValue;

            public MyClass()
            {
                ReadOnlyValue = 10;
            }
        }
    }
}
