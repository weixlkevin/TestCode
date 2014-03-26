using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TestICloneable test1 = new TestICloneable();
            TestICloneable test2 = test1.Clone();
            test1.Age = "10";
            test1.Names.Add("weixl");
            test2.AddName("kevin");
            test1.ShowAge();
            test2.ShowAge();
            test1.ShowName();
            test2.ShowName();
            Console.ReadKey();
        }
    }
}
