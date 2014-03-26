using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Sale:AbstractorColleague
    {
        public Sale(AbstractMediator mediator):base(mediator)
        {

        }

        public int GetSaleStatus()
        {
            Random random = new Random(0);
            int saleStatus = random.Next(1000);
            Console.WriteLine("IBM 电脑销售情况为：" + saleStatus);
            return saleStatus;
        }
    }
}
