using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExtend
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Car car = Car.GetInstance();
                car.Move();
            }

            Console.ReadKey();
        }
    }
}
