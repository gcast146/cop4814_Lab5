//comment at step 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



//c
//h
//a
//n
//g
//e
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    class GameFactory
    {
        List<Game> GameList = new List<Game>();
        public string FilePath = @"..\..\games.xml";
//change
        public void CreateGameList()
        {
            GameList.Add(new Game("Test Team One", "Test Team 2", 1, 2));
            GameList.Add(new Game("Senators", "Lightning", 4, 1));
            GameList.Add(new Game("Predators", "Jets", 4, 3));
            GameList.Add(new Game("Coyotes", "Ducks", 0, 2));
            GameList.Add(new Game("Rangers", "Devils", 2, 5));
            GameList.Add(new Game("Flames", "Sharks", 1, 0));
        }
//change
        public Boolean SerializeGameList()
        {
            StreamWriter sw = new StreamWriter(FilePath);
            XmlSerializer serial = new XmlSerializer(GameList.GetType());
            serial.Serialize(sw, GameList);
            sw.Close();
            return true;
        }
        
        
        
        
        
    }//more changes
}
