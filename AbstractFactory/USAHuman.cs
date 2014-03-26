using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class USAHuman:AbstractHuman
    {
        public USAHuman()
        {
            base.SkinColor = "白色";
        }

        public override void Speak()
        {
            Console.WriteLine("I'm speaking english");
        }
    }
}
