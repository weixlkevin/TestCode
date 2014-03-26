using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Purchase : AbstractorColleague
    {
        public Purchase(AbstractMediator mediator)
            : base(mediator)
        {

        }

        public void buy(int number)
        {
            base.mediator.Execute<int>("purchase.buy", number);
        }
    }
}
