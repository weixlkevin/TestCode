using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new Factory();
            AbstractHuman human = factory.CreatProduct<ChineseHuman>(new ChineseHuman());
            human.Speak();
            IUseChopsticksToEat humanCanUseChopstick = factory.CreatProduct<ChineseHuman>(new ChineseHuman());
            humanCanUseChopstick.UseChopstick();
            Console.ReadKey();
        }
    }
}
