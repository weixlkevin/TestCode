using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHummerCar car = new Hummer1();
            car.Run();
            car = new Hummer2();
            car.Run();
            Console.ReadKey();
        }
    }
}
