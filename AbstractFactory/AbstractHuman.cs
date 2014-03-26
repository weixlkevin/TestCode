using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractHuman
    {
        public string SkinColor { get; set; }

        public string Sex { get; set; }

        public virtual void Think()
        {
            Console.WriteLine("I'm thingking now!'");
        }

        public abstract void Speak();
    }
}
