using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Stock : AbstractorColleague
    {
        public Stock(AbstractMediator mediator)
            : base(mediator)
        {

        }

        private static int COMPUTER_NUMBER = 100;

        public void Increase(int number)
        {
            COMPUTER_NUMBER += number;
            Console.WriteLine("库存数量为：" + COMPUTER_NUMBER + "台");
        }
    }
}
