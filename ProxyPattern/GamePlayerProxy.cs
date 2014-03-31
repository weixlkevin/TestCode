using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GamePlayerProxy : IGamePlayer, IProxy
    {
        private IGamePlayer gamePlayer = null;

        public GamePlayerProxy(string name)
        {
            this.gamePlayer = new GamePlayer(name);
        }

        public void Login(string user, string password)
        {
            this.gamePlayer.Login(user, password);
        }

        public void KillBose()
        {
            this.gamePlayer.KillBose();
        }

        public void Upgrade()
        {
            this.gamePlayer.Upgrade();
        }

        public void Count()
        {
            Console.WriteLine("升级总费用是: 150元.");
        }
    }
}
