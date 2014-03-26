using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Father f = new Father();
            Women women = new Women(2, "逛街");
            f.HandlerMessage(women, true);
            Husband h = new Husband();
            h.HandlerMessage(women, false);
            Console.ReadKey();
        }
    }
}
