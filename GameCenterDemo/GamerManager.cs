using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer added.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" Gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");
        }
    }
}
