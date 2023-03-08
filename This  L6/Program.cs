using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This__L6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass name = new MyClass();
            name.SetName("Josh");
            name.PrintName();
            Console.ReadKey();
        }
    }
    class MyClass
    {
        private string name;//1.name

        public void SetName(string name)// 2. name //there is a 2 name variable and its confusing
        {
            this.name = name;//this help us 
            //when we put "this" it marks 1.name 
            //that means 1.name==2.name
        }

        public void PrintName()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
}


