using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Mediator : AbstractMediator
    {

        public override void Execute<T>(string str, T obj)
        {
            if (str.Equals("purchase.buy"))
            {
                this.buyComputer(obj);
            }
        }

        private void buyComputer<T>(T num)
        {
            int number = 0;
            if (int.TryParse(num.ToString(), out number))
            {
                int saleStatus = base.sale.GetSaleStatus();
                if (saleStatus > 80)
                {
                    Console.WriteLine("采购IBM电脑" + number + "台");
                    base.stock.Increase(number);
                }
                else
                {
                    int buyNumber = number / 2;
                    Console.WriteLine("采购IBM电脑" + number + "台");
                    base.stock.Increase(buyNumber);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
