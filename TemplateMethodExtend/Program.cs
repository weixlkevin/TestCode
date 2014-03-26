using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExtend
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHummerCar car = new Hummer1();
            car.Run((c) =>
            {
                if (c.IsAlarm())
                {
                    c.Alarm();
                }
                c.EngineBoom();
                c.Start();
                c.Stop();
            });
            car = new Hummer2();
            car.Run((c) =>
            {
                if (c.IsAlarm())
                {
                    c.Alarm();
                }
                c.EngineBoom();
                c.Start();
                c.Stop();
            });
            Console.ReadKey();
        }
    }
}
