using System;
using System.Collections.Generic;
using System.Text;

namespace GameProductManager
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+ " Oyunu Eklendi!");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Silindi!");
        }
        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Güncellendi!");
        }
        public void ListGame(Game[] game)
        {
            Console.WriteLine("Mevcut Oyunlar Listeleniyor...");
            foreach (var item in game)
            {

                Console.WriteLine(" {0} ",item.GameName);
            }
        }
    }
}
