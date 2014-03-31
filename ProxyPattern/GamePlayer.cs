using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GamePlayer : IGamePlayer
    {
        private string name = string.Empty;

        public GamePlayer(string Name)
        {
            this.name = Name;
        }

        public void Login(string user, string password)
        {
            Console.WriteLine("登录名:" + user + "的用户:" + this.name + "登录成功!");
        }

        public void KillBose()
        {
            Console.WriteLine(this.name + "正在打怪!");
        }

        public void Upgrade()
        {
            Console.WriteLine(this.name + "升一级了!");
        }
    }
}
