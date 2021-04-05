using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo
{
    class SaleManager
    {
        public void Sale(Gamer gamer,Campaign campaign,Game game)
        {
            Console.WriteLine("Gamer : "+ gamer.FirstName+ " " + gamer.LastName + " buy "+game.GameName +" " + " benefited from the " + campaign.Name);
        }
    }
}
