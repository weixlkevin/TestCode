using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class AbstractWomen
    {
        public abstract int GetType();

        public abstract string GetRequest();
        
    }
}
