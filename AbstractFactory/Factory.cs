using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Factory:AbstractFactory
    {
        public override T CreatProduct<T>(T product)
        {
            return new T();
        }
    }
}
