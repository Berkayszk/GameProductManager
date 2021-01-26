using System;
using System.Collections.Generic;
using System.Text;

namespace GameProductManager
{
    class CampaignManager
    {
        
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignType + " Eklendi");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignType + " Silindi");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignType+ " Güncellendi" );
        }
        public void CampaignList(Campaign[] campaign)
        { 
            Console.WriteLine("Kampanyalar Listeleniyor...");
            foreach (var item in campaign)
            {
                Console.WriteLine(" {0} ",item.CampaignType);   

            }
        }
        public void Discount(Campaign campaign,Game game)
        {
            
            Console.WriteLine("{0} Kampanyasında {1} Oyununa %{2} indirim uygulanacaktır",campaign.CampaignType,game.GameName,campaign.DiscountRate);
        }
    }
}
