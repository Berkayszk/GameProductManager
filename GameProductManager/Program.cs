using System;

namespace GameProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { FirstName = "Berkay", LastName = "Sazak", TcNo = "12312312311", BirthYear = "2001"  };
            Customer customer2 = new Customer() { FirstName = "Murat", LastName = "Musk", TcNo = "12312512311", BirthYear = "2003" };
            Customer customer3 = new Customer() { FirstName = "Ali", LastName = "Yemiş", TcNo = "14512512311", BirthYear = "1999" };

            //Kullanıcıları Listelemek İstiyoroum
            Customer[] customers = new Customer[] { customer1,customer2,customer3 };
            
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer3);
            //listele
            customerManager.CustomerList(customers);
            //silme
            customerManager.Delete(customer1);
            //güncelleme
            customerManager.Update(customer2);

            ///////////////////////Oyunların bölümü ///////////////////////////////////////
            Game game1 = new Game() { GameName="Gta 5",GameReleaseYear=2015,GameType="Action" };
            Game game2 = new Game() { GameName = "Gta 4", GameReleaseYear = 2010, GameType = "Action" };
            Game game3 = new Game() { GameName = "Gta San Andreas", GameReleaseYear = 2008, GameType = "Action" };
            Game game4 = new Game() { GameName = "COD MW", GameReleaseYear = 2012, GameType = "Action" };
            Game game5 = new Game() { GameName = "Cyberpunk 2077", GameReleaseYear = 2020, GameType = "Action" };
            Game game6 = new Game() { GameName = "Sims4", GameReleaseYear = 2018, GameType = "Simulator" };
            //Listelemek için
            Game[] games = new Game[] { game1, game2 , game3 , game4 , game5 , game6 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1); 
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Add(game4);
            gameManager.Add(game5);
            gameManager.Add(game6);
            gameManager.Delete(game5);
            gameManager.Update(game4);
            gameManager.ListGame(games);
            ////////////////////////////////Kampanya Bölümü/////////////////////////////////////////
            Campaign campaign1 = new Campaign() { CampaignType = "Black Friday", DiscountRate = 30 };
            Campaign campaign2 = new Campaign() { CampaignType = "Student Campaign", DiscountRate = 40 };
            Campaign campaign3 = new Campaign() { CampaignType = "College Campaign", DiscountRate = 10 };
            Campaign campaign4 = new Campaign() { CampaignType = "Summer Discount", DiscountRate = 20};
            //Listelemek için
            Campaign[] campaigns = new Campaign[] { campaign1, campaign2 , campaign3 , campaign4 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            campaignManager.Add(campaign4);
            campaignManager.Delete(campaign3);
            campaignManager.CampaignList(campaigns);
            campaignManager.Update(campaign2);
            campaignManager.Discount(campaign1,game4);
            

        }
    }
}
