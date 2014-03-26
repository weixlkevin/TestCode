using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Hummer2:AbstractHummerCar
    {
        public override void Alarm()
        {
            Console.WriteLine("hummer2 alarm");
        }

        public override void EngineBoom()
        {
            Console.WriteLine("hummer2 EngineBoom");
        }

        public override void Start()
        {
            Console.WriteLine("hummer2 Start");
        }

        public override void Stop()
        {
            Console.WriteLine("hummer2 Stop");
        }
    }
}
