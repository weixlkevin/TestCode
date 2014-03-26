using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
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

        public void Run()
        {
            if (this.IsAlarm())
            {
                this.Alarm();
            }
            this.EngineBoom();
            this.Start();
            this.Stop();
        }
    }
}
