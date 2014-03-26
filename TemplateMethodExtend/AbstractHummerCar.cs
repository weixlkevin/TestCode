using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExtend
{
    public abstract class AbstractHummerCar
    {
        public abstract void Alarm();

        public abstract void EngineBoom();

        public abstract void Start();

        public abstract void Stop();

        public virtual bool IsAlarm()
        {
            return true;
        }

        public void Run(Action<AbstractHummerCar>car)
        {
            car(this);
        }
    }
}
