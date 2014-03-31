using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface IGamePlayer
    {
        void Login(string user, string password);

        void KillBose();

        void Upgrade();

    }
}
