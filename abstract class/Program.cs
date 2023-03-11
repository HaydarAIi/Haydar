using System;
using static System.Console;

namespace abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Red;
            // Abstract1 abstract1 = new Abstract1(); cannot be instantiated in this type
            // Abstract1.deneme(); // can be defined this way
            ReadLine();
        }
    }
    class DerivedClass1 : Abstract1
    {
        public override void deneme1()// Must be used here because abstract is used
        {
        }
    }
    class DerivedClass2 : Abstract1
    {
        public override void deneme1()// Must be used here because abstract is used
        {
        }
    }

    
    abstract class Abstract1// Generally used to create a template 
    {
        // Everything defined in this class must be used in the classes inherited from it

        public static void deneme()
        {
            WriteLine("Abstract test");
        }
        public abstract void deneme1();

    }
}
