using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class AbstractorColleague
    {
        protected AbstractMediator mediator;
        public AbstractorColleague(AbstractMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
