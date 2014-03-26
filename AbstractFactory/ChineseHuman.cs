using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ChineseHuman : AbstractHuman, IUseChopsticksToEat
    {
        public ChineseHuman()
        {
            base.SkinColor = "黄色";
        }

        public override void Speak()
        {
            Console.WriteLine("I'm speaking chinese");
        }

        public void UseChopstick()
        {
            Console.WriteLine("I can use chopstick to eat");
        }
    }
}
