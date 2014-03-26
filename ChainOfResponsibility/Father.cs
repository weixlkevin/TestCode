using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Father : IHandler
    {
        public void HandlerMessage(AbstractWomen women, bool isAgree)
        {
            if (women.GetType() == 1)
            {
                Console.WriteLine("女儿的请示是" + women.GetRequest());
                string output = string.Empty;
                output = (isAgree) ? "同意" : "不同意";
                Console.WriteLine(output);
            }
        }
    }
}
