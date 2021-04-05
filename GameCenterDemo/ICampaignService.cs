using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo
{
    interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Delete(Campaign campaign);
        public void Update(Campaign campaign);
    }
}
