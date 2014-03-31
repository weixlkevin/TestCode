using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamePlayer player = new GamePlayer("张三");
            //Console.WriteLine("游戏开始时间:"+DateTime.Now);
            //player.Login("zhangsan", "password");
            //player.KillBose();
            //player.Upgrade();
            //Console.WriteLine("游戏结束时间:" + DateTime.Now);
            GamePlayerProxy proxy = new GamePlayerProxy("张三");
            Console.WriteLine("游戏开始时间:" + DateTime.Now);
            proxy.Login("zhangsan", "password");
            proxy.KillBose();
            proxy.Upgrade();
            proxy.Count();
            Console.WriteLine("游戏结束时间:" + DateTime.Now);

            Console.ReadKey();
        }
    }
}
