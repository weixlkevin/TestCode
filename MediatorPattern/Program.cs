﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Purchase purchase = new Purchase(new Mediator());
            purchase.buy(100);
            Console.ReadKey();
        }
    }
}
