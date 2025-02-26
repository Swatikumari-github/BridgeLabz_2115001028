

namespace json
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System.IO;
    using Newtonsoft.Json;
    using CsvHelper;
    using System.Globalization;

    public class IPLMatch
    {
        public int MatchId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public Dictionary<string, int> Score { get; set; }
        public string Winner { get; set; }
        public string PlayerOfMatch { get; set; }
    }
    public static class CensorshipHelper
    {
        public static string MaskTeamName(string teamName)
        {
            // Replace part of the team name with "***"
            if (teamName.Contains("Mumbai"))
                return teamName.Replace("Mumbai", "Mumbai ***");
            if (teamName.Contains("Chennai"))
                return teamName.Replace("Chennai", "Chennai ***");
            if (teamName.Contains("Royal"))
                return teamName.Replace("Royal", "Royal ***");
            if (teamName.Contains("Delhi"))
                return teamName.Replace("Delhi", "Delhi ***");

            return teamName;
        }

        public static string MaskPlayerOfMatch(string playerName)
        {
            // Replace the player of the match with "REDACTED"
            return "REDACTED";
        }
    }
  


public class JsonProcessor
    {
        public static void ProcessJson(string inputFile, string outputFile)
        {
            // Read the JSON data from file
            var jsonData = File.ReadAllText(inputFile);

            // Deserialize JSON into a list of IPLMatch objects
            var matches = JsonConvert.DeserializeObject<List<IPLMatch>>(jsonData);

            // Apply censorship rules
            foreach (var match in matches)
            {
                match.Team1 = CensorshipHelper.MaskTeamName(match.Team1);
                match.Team2 = CensorshipHelper.MaskTeamName(match.Team2);

                // Mask the score as well
                var updatedScore = new Dictionary<string, int>();
                foreach (var score in match.Score)
                {
                    updatedScore[CensorshipHelper.MaskTeamName(score.Key)] = score.Value;
                }
                match.Score = updatedScore;

                match.Winner = CensorshipHelper.MaskTeamName(match.Winner);
                match.PlayerOfMatch = CensorshipHelper.MaskPlayerOfMatch(match.PlayerOfMatch);
            }

            // Serialize the modified data back to JSON
            var censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);

            // Write the sanitized JSON to the output file
            File.WriteAllText(outputFile, censoredJson);
            Console.WriteLine("Censored JSON file has been written.");
        }
    }


public class CsvProcessor
    {
        public static void ProcessCsv(string inputFile, string outputFile)
        {
            // Read the CSV data from file
            using (var reader = new StreamReader(inputFile))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Read the records from CSV
                var records = csv.GetRecords<dynamic>();
                var sanitizedRecords = new List<dynamic>();

                foreach (var record in records)
                {
                    var sanitizedRecord = new Dictionary<string, object>
                {
                    { "match_id", record.match_id },
                    { "team1", CensorshipHelper.MaskTeamName(record.team1) },
                    { "team2", CensorshipHelper.MaskTeamName(record.team2) },
                    { "score_team1", record.score_team1 },
                    { "score_team2", record.score_team2 },
                    { "winner", CensorshipHelper.MaskTeamName(record.winner) },
                    { "player_of_match", CensorshipHelper.MaskPlayerOfMatch(record.player_of_match) }
                };
                    sanitizedRecords.Add(sanitizedRecord);
                }

                // Write the sanitized CSV data to output
                using (var writer = new StreamWriter(outputFile))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(sanitizedRecords);
                }

                Console.WriteLine("Censored CSV file has been written.");
            }
        }
    }


    class Prog16
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string jsonInputFile = "ipl_matches.json"; // Replace with your actual input file path
            string csvInputFile = "ipl_matches.csv";   // Replace with your actual input file path

            string jsonOutputFile = "ipl_matches_censored.json";  // Output file path for JSON
            string csvOutputFile = "ipl_matches_censored.csv";    // Output file path for CSV

            // Process JSON file
            JsonProcessor.ProcessJson(jsonInputFile, jsonOutputFile);

            // Process CSV file
            CsvProcessor.ProcessCsv(csvInputFile, csvOutputFile);
        }
    }

}
