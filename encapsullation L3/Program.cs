
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsullation_L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Citroen";
            car.Model = "C5";
            car.year = 2008;
        }
    }
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
          
        public int year { get; set; }   

    }
}
