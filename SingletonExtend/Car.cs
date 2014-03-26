using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExtend
{
    public class Car
    {
        private Car()
        { }

        private string name { get; set; }

        private static int maxOfCar = 2;
        private static List<Car> cars = new List<Car>();

         static Car()
        {
            for (int i = 0; i < maxOfCar; i++)
            {
                Car car = new Car() { name="ford"+i.ToString()};
                cars.Add(car);
            }
        }

        public static Car  GetInstance()
        {
            Random random = new Random();
            return cars[random.Next(2)];
        }

        public void Move()
        {
            Console.WriteLine(name+"I'm moving now!");
        }

    }
}
