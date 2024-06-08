using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballStatsApp;

namespace FootballStatsApp
{
    public class Player
    {
        public string Name { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }

        public Player(string name, int goals, int assists, int yellowCards, int redCards, string teamName)
        {
            Name = name;
            Goals = goals;
            Assists = assists;
            YellowCards = yellowCards;
            RedCards = redCards;
        }
    }
}
