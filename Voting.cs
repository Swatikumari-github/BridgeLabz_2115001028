using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
   
    public class VotingSystem
    {
        // Dictionary to store votes with candidates as keys
        private Dictionary<string, int> votes = new Dictionary<string, int>();

        // SortedDictionary to store votes sorted by candidate name
        private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();

        // List to maintain the insertion order of votes (simulating LinkedHashMap)
        private List<KeyValuePair<string, int>> orderedVotes = new List<KeyValuePair<string, int>>();

        // Add a vote for a candidate
        public void CastVote(string candidate)
        {
            // Update Dictionary with vote count
            if (votes.ContainsKey(candidate))
            {
                votes[candidate]++;
            }
            else
            {
                votes[candidate] = 1;
            }

            // Update SortedDictionary with vote count
            sortedVotes[candidate] = votes[candidate];

            // Update List with insertion order
            var existingVote = orderedVotes.FirstOrDefault(v => v.Key == candidate);
            if (existingVote.Equals(default(KeyValuePair<string, int>)))
            {
                orderedVotes.Add(new KeyValuePair<string, int>(candidate, 1));
            }
            else
            {
                orderedVotes.Remove(existingVote);
                orderedVotes.Add(new KeyValuePair<string, int>(candidate, votes[candidate]));
            }
        }

        // Get all the votes in the order of insertion (LinkedHashMap style)
        public IEnumerable<KeyValuePair<string, int>> GetVotesInInsertionOrder()
        {
            return orderedVotes;
        }

        // Get sorted votes by candidate name (SortedDictionary)
        public IEnumerable<KeyValuePair<string, int>> GetSortedVotesByName()
        {
            return sortedVotes;
        }

        // Get votes in descending order of votes (to show top-voted candidates first)
        public IEnumerable<KeyValuePair<string, int>> GetVotesByDescendingOrder()
        {
            return votes.OrderByDescending(v => v.Value);
        }

        // Get vote count for a specific candidate
        public int GetVoteCount(string candidate)
        {
            return votes.ContainsKey(candidate) ? votes[candidate] : 0;
        }
    }

    class Voting
    {
        static void Main()
        {
            var votingSystem = new VotingSystem();

            // Simulating some votes
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Bob");
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Charlie");
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Bob");

            // Display all votes in the order they were inserted
            Console.WriteLine("Votes in Insertion Order (LinkedHashMap Style):");
            foreach (var vote in votingSystem.GetVotesInInsertionOrder())
            {
                Console.WriteLine($"{vote.Key}: {vote.Value} votes");
            }

            // Display sorted votes by candidate name (SortedDictionary)
            Console.WriteLine("\nVotes Sorted by Candidate Name:");
            foreach (var vote in votingSystem.GetSortedVotesByName())
            {
                Console.WriteLine($"{vote.Key}: {vote.Value} votes");
            }

            // Display votes sorted by descending order (to see top candidates first)
            Console.WriteLine("\nVotes Sorted by Number of Votes (Descending Order):");
            foreach (var vote in votingSystem.GetVotesByDescendingOrder())
            {
                Console.WriteLine($"{vote.Key}: {vote.Value} votes");
            }

            // Get specific vote count for a candidate
            string candidate = "Alice";
            Console.WriteLine($"\nVote count for {candidate}: {votingSystem.GetVoteCount(candidate)}");
        }
    }

}
