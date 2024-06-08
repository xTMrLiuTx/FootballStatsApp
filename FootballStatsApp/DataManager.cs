using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FootballStatsApp;

namespace FootballStatsApp
{
    public class DataManager
    {
        private List<Team> teams;
        private List<Match> matches;
        private List<Player> players;
        private List<MatchStats> matchStats;
        private DataManager dataManager;

        public DataManager()
        {
            // Inicializar las listas al crear una nueva instancia del DataManager
            teams = new List<Team>();
            matches = new List<Match>();
            players = new List<Player>();
            matchStats = new List<MatchStats>();

            // Cargar los datos al iniciar la aplicación
            LoadData();
        }

        public void LoadData(string teamsFilePath, string playersFilePath, string matchStatsFilePath)
        {
            // Implementar lógica para cargar datos desde archivos de texto
            LoadTeamsFromFile(teamsFilePath);
            LoadPlayersFromFile(playersFilePath);
            LoadMatchStatsFromFile(matchStatsFilePath);
            ReadMatchStatsFromFile(matchStatsFilePath);
        }


        public List<Team> GetTeams()
        {
            return teams;
        }

        public void AddTeam(string teamName, string country)
        {
            if (!teams.Exists(t => t.Name == teamName))
            {
                Team team = new Team { Name = teamName, Country = country };
                teams.Add(team);
            }
        }

        public void EditTeam(string teamName, Team newTeamData)
        {
            // Buscar el equipo por nombre
            Team existingTeam = teams.Find(t => t.Name == teamName);

            if (existingTeam != null)
            {
                // Actualizar los datos del equipo
                existingTeam.Name = newTeamData.Name;
                existingTeam.Country = newTeamData.Country;
                // Actualizar otros datos según sea necesario
            }
            else
            {
                // Manejar el caso en el que el equipo no se encuentre
            }
        }

        public void DeleteTeam(string teamName)
        {
            // Buscar el equipo por nombre
            Team teamToDelete = teams.Find(t => t.Name == teamName);

            if (teamToDelete != null)
            {
                // Eliminar el equipo de la lista
                teams.Remove(teamToDelete);
                // También puedes implementar la lógica para eliminar los jugadores del equipo si es necesario
            }
            else
            {
                // Manejar el caso en el que el equipo no se encuentre
            }
        }

        // Método para buscar un equipo por su nombre
        public Team FindTeam(string teamName)
        {
            return teams.Find(t => t.Name == teamName);
        }

        public void AddPlayerToTeam(string teamName, Player player)
        {
            Team team = FindTeam(teamName);
            if (team != null)
            {
                team.AddPlayer(player);
            }
        }

        public void UpdatePlayerStats(string teamName, string playerName, int goals, int assists, int yellowCards, int redCards)
        {
            Team team = FindTeam(teamName);
            if (team != null)
            {
                team.UpdatePlayerStats(playerName, goals, assists, yellowCards, redCards);
            }
        }

        public List<Team> GetTournamentStandings()
        {
            List<Team> standings = GetAllTeams();
            standings = standings.OrderByDescending(team => team.Points).ToList();
            return standings;
        }


        // Suponiendo que este método devuelve la lista de todos los equipos
        private List<Team> GetAllTeams()
        {
            // Implementa la lógica para obtener todos los equipos
            throw new NotImplementedException();
        }



        public List<Player> GetAllPlayersInTeam(string teamName)
        {
            Team team = FindTeam(teamName);
            if (team != null)
            {
                return team.Players;
            }
            return new List<Player>();
        }

        public void EditMatch(int index, Match match)
        {
            matches[index] = match;
        }

        public void DeleteMatch(int index)
        {
            if (index >= 0 && index < matchStats.Count)
            {
                matchStats.RemoveAt(index);
            }
            else
            {
                // Manejar el caso en el que el índice esté fuera de rango
            }
        }

        private void LoadData()
        {
            // Cargar equipos desde el archivo "teams.txt"
            LoadTeamsFromFile("teams.txt");

            // Cargar partidos desde el archivo "matches.txt"
            LoadMatchesFromFile("matchStats.txt", 5);

            // Cargar jugadores desde el archivo "players.txt"
            LoadPlayersFromFile("players.txt");
        }

        private void LoadTeamsFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Separar los datos de la línea
                        string[] data = line.Split('\t');

                        // Crear un nuevo objeto Team y agregarlo a la lista de equipos
                        Team team = new Team
                        {
                            Name = data[0],
                            Country = data[1],
                            // Asignar otras propiedades según la estructura del archivo
                        };

                        teams.Add(team);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la lectura del archivo
                MessageBox.Show($"Error al cargar los equipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMatchesFromFile(string filePath, int numMatches)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int matchCount = 0;
                    while ((line = reader.ReadLine()) != null && matchCount < numMatches)
                    {
                        // Dividir la línea en sus partes individuales
                        string[] parts = line.Split('\t');

                        // Verificar si hay suficientes elementos en la línea
                        if (parts.Length >= 6)
                        {
                            string homeTeam = parts[0];
                            string awayTeam = parts[1];
                            int homeGoals, awayGoals;
                            DateTime date;
                            string stadium;

                            // Intentar convertir los goles de local y de visitante
                            if (!int.TryParse(parts[2], out homeGoals) || !int.TryParse(parts[3], out awayGoals))
                            {
                                // Si la conversión falla, puedes manejarlo según sea necesario
                                // Aquí puedes lanzar una excepción, mostrar un mensaje de error, etc.
                                continue; // Continuar con la próxima línea si no se puede convertir los goles
                            }

                            // Intentar convertir la fecha
                            if (!DateTime.TryParse(parts[4], out date))
                            {
                                // Si la conversión falla, puedes manejarlo según sea necesario
                                // Aquí puedes lanzar una excepción, mostrar un mensaje de error, etc.
                                continue; // Continuar con la próxima línea si no se puede convertir la fecha
                            }

                            // El resto de los datos son cadenas, por lo que no es necesario validarlos aquí

                            stadium = parts[5];

                            // Crear una nueva instancia de MatchStats
                            MatchStats match = new MatchStats(homeTeam, awayTeam, homeGoals, awayGoals, date, stadium);

                            // Agregar la partida al sistema
                            dataManager.AddMatch(match);

                            matchCount++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la lectura del archivo
                MessageBox.Show($"Error al cargar los partidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPlayersFromFile(string filePath)
        {
            // Implementar lógica para cargar jugadores desde un archivo de texto
        }

        private void LoadPlayerStatsFromFile(string filePath)
        {
            // Implementar lógica para cargar estadísticas de jugadores desde un archivo de texto
        }

        private void LoadMatchStatsFromFile(string filePath)
        {
            // Implementar lógica para cargar estadísticas de partidos desde un archivo de texto
        }

        // Método para agregar un nuevo partido
        public void AddMatch(MatchStats match)
        {
            matchStats.Add(match);
        }

        // Método para editar un partido existente
        public void EditMatch(int index, MatchStats updatedMatch)
        {
            if (index >= 0 && index < matchStats.Count)
            {
                matchStats[index] = updatedMatch;
            }
            else
            {
                // Manejar el caso en el que el índice esté fuera de rango
            }
        }



        private List<MatchStats> ReadMatchStatsFromFile(string filePath)
        {
            List<MatchStats> matchStats = new List<MatchStats>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Separar los datos de la línea
                        string[] data = line.Split('\t');

                        // Convertir los datos en el formato adecuado y crear un nuevo objeto MatchStats
                        MatchStats match = new MatchStats
                        {
                            Date = DateTime.Parse(data[0]),
                            HomeTeam = data[1],
                            AwayTeam = data[2],
                            HomeGoals = int.Parse(data[3]),
                            AwayGoals = int.Parse(data[4]),
                            Stadium = data[5]
                            // Agregar otros datos según sea necesario
                        };

                        // Agregar el partido a la lista de matchStats
                        matchStats.Add(match);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la lectura del archivo
                MessageBox.Show($"Error al cargar las estadísticas de partidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return matchStats;
        }


        // Método para obtener la lista de estadísticas de partidos
        public List<MatchStats> GetMatchStats()
        {
            return matchStats;
        }

        internal object GetMatches()
        {

            return matches;
        }



        public void AddTeam(Team newTeam)
        {
            if (!teams.Exists(t => t.Name == newTeam.Name))
            {
                teams.Add(newTeam);
            }
            else
            {
                // Manejar el caso en el que el equipo ya existe
            }
        }

    }
}