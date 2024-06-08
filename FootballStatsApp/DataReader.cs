using System;
using System.Collections.Generic;
using System.IO;
using FootballStatsApp;

namespace FootballStatsApp
{
    public class DataReader
    {
        public List<Team> ReadTeamsFromFile(string filePath)
        {
            List<Team> teams = new List<Team>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('\t');
                        string teamName = data[0];
                        string country = data[1];
                        teams.Add(new Team(teamName, country));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading teams file: " + ex.Message);
            }

            return teams;
        }

        public List<Player> ReadPlayersFromFile(string filePath)
        {
            List<Player> players = new List<Player>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('\t');
                        string playerName = data[0];
                        int goals = int.Parse(data[1]);
                        int assists = int.Parse(data[2]);
                        int yellowCards = int.Parse(data[3]);
                        int redCards = int.Parse(data[4]);
                        string teamName = data[5];
                        players.Add(new Player(playerName, goals, assists, yellowCards, redCards, teamName));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading players file: " + ex.Message);
            }

            return players;
        }

        public List<MatchStats> ReadMatchStatsFromFile(string filePath)
        {
            List<MatchStats> matchStats = new List<MatchStats>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('\t');
                        DateTime date = DateTime.Parse(data[0]);
                        string homeTeam = data[1];
                        string awayTeam = data[2];
                        int homeGoals = int.Parse(data[3]);
                        int awayGoals = int.Parse(data[4]);
                        string stadium = data[5];
                        matchStats.Add(new MatchStats(date, homeTeam, awayTeam, homeGoals, awayGoals, stadium));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading match stats file: " + ex.Message);
            }

            return matchStats;
        }
    }
}
