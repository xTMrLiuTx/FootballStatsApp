using System;
using System.Collections.Generic;
using System.IO;
using FootballStatsApp;

namespace FootballStatsApp
{
    public class DataWriter
    {
        public void WriteMatchStatsToFile(List<MatchStats> matchStats, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var match in matchStats)
                    {
                        // Formateamos los datos en una línea de texto antes de escribirlos en el archivo
                        string line = $"{match.Date}\t{match.HomeTeam}\t{match.AwayTeam}\t{match.HomeGoals}\t{match.AwayGoals}\t{match.Stadium}";
                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing match stats file: " + ex.Message);
            }
        }
    }
}

