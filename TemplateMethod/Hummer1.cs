using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Hummer1 : AbstractHummerCar
    {
        public override void Alarm()
        {
            Console.WriteLine("hummer1 alarm");
        }

        public override void EngineBoom()
        {
            Console.WriteLine("hummer1 EngineBoom");
        }

        public override void Start()
        {
            Console.WriteLine("hummer1 Start");
        }

        public override void Stop()
        {
            Console.WriteLine("hummer1 Stop");
        }

        public override bool IsAlarm()
        {
            return false;
        }

        public void Run(Action<Hummer1> carRun)
        {
            carRun(this);
        }
    }
}
