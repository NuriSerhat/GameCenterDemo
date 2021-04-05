using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo
{
    class CheckManager : ICheckService
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.FirstName=="Nuri" && gamer.LastName=="ARSLAN" && gamer.DateOfBirth==1991 && gamer.TcNo=="12345678901")
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
