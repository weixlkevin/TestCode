using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class TestICloneable
    {
        public TestICloneable()
        {
            Console.WriteLine("执行构造函数");
        }

        public string Age { get; set; }

        public IList<string> names = new List<string>();

        public IList<string> Names
        {
            get { return names; }
            set { names = value; }
        }

        public void ShowAge()
        {
            Console.WriteLine(Age == null ? "空字符串" : Age);
        }

        public void ShowName()
        {
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
        }

        public void AddName(string name)
        {
            Names.Add(name);
        }

        public TestICloneable Clone()
        {
            TestICloneable test = null;
            try
            {
                test = (TestICloneable)this.MemberwiseClone();//浅拷贝
                this.names = new List<string>();//深拷贝
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return test;
        }
    }
}
