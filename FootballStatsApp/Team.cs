using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballStatsApp;

namespace FootballStatsApp
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public object Points { get; internal set; }

        public Team(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public Team()
        {
        }

        // Método para agregar un jugador al equipo
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        // Método para buscar un jugador por su nombre
        public Player FindPlayer(string playerName)
        {
            return Players.Find(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase));
        }

        // Método para actualizar las estadísticas de un jugador
        public void UpdatePlayerStats(string playerName, int goals, int assists, int yellowCards, int redCards)
        {
            Player player = FindPlayer(playerName);
            if (player != null)
            {
                player.Goals = goals;
                player.Assists = assists;
                player.YellowCards = yellowCards;
                player.RedCards = redCards;
            }
        }
    }
}

