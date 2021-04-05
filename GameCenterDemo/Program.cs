using System;

namespace GameCenterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.TcNo = "12345678901";
            gamer1.FirstName = "Nuri";
            gamer1.LastName = "ARSLAN";
            gamer1.DateOfBirth = 1991;

            Gamer gamer2 = new Gamer();
            gamer2.TcNo = "10987654321";
            gamer2.FirstName = "Funda";
            gamer2.LastName = "SAĞLAMLI";
            gamer2.DateOfBirth = 1993;

            Campaign campaign1 = new Campaign { Name = "Christmas Campaign", Discount = 25 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            Game game1 = new Game();
            game1.GameName = "Contra";
            game1.SalesPrice = 7.85;

            Game game2 = new Game();
            game2.GameName = "World Of Warcraft";
            game2.SalesPrice = 115;

            IGamerService gamerManager = new GamerManager();
            gamerManager.Add(gamer1);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, campaign1, game2);

            CheckManager checkManager = new CheckManager();
            checkManager.Check(gamer2);

        }

      
    }
}
