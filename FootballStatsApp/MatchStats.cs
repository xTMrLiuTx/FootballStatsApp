using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballStatsApp;

namespace FootballStatsApp
{
    public struct MatchStats
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public DateTime Date { get; set; }
        public string Stadium { get; set; }
        public DateTime Timestamp { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public int HomeTeamGoalCount { get; set; }
        public int AwayTeamGoalCount { get; set; }

        public MatchStats(string homeTeam, string awayTeam, int homeGoals, int awayGoals, DateTime date, string stadium)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
            Date = date;
            Stadium = stadium;
        }

        public MatchStats(DateTime date, string homeTeam, string awayTeam, int homeGoals, int awayGoals, string stadium) : this()
        {
            Date = date;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
            Stadium = stadium;
        }
    }
}

       