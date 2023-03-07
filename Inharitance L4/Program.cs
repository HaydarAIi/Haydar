using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop abc = new Laptop("Apple","Mac",19000,16,528);
            abc.PrintInfo();
            
            Phone def = new Phone("Xiaomi","Mi 8",2000,"s",128);
            def.PrintInfo();
            Console.ReadKey();

        }
    }
    public class Device
    {
        protected string brand;
        protected string model;
        protected double price;

        public Device(string brand, string model, double price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Brand: {brand}\nModel: {model}\nPrice: {price}\n");
        }
    }

    public class Laptop : Device
    {
        private int ram;
        private int storage;

        public Laptop(string brand, string model, double price, int ram, int storage) : base(brand, model, price)
        {
            this.ram = ram;
            this.storage = storage;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Type: Laptop\nBrand: {brand}\nModel: {model}\nPrice: {price}\nRAM: {ram} GB\nStorage: {storage} GB\n");
        }
    }

    public class Phone : Device
    {
        private string os;
        private int storage;

        public Phone(string brand, string model, double price, string os, int storage) : base(brand, model, price)
        {
            this.os = os;
            this.storage = storage;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Type: Phone\nBrand: {brand}\nModel: {model}\nPrice: {price}\nOperating System: {os}\nStorage: {storage} GB\n");
        }
    }
}
