using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo
{
    interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Delete(Gamer gamer);
        public void Update(Gamer gamer);
    }
}
