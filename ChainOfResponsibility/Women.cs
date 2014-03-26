using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Women : AbstractWomen
    {
        private int womenType = 0;
        private string womenRequest = string.Empty;

        public Women(int womenType, string womenRequest)
        {
            this.womenRequest = womenRequest;
            this.womenType = womenType;
        }

        public override int GetType()
        {
            return womenType;
        }

        public override string GetRequest()
        {
            return womenRequest;
        }
    }
}
