using System;
using System.Collections.Generic;
using System.Linq;



namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //PArrallel lists for storing details
            List<string> candidates = new List<string>();
            List<string> parties = new List<string>();
            List<int> votes = new List<int>();
            //Get n value
            int n = Convert.ToInt32(Console.ReadLine());
            //Loop through to get candidates and their parties details
            for (int i = 0; i < n; i++)
            {
                candidates.Add(Console.ReadLine());
                parties.Add(Console.ReadLine());
                votes.Add(0);
            }
            //Get m value
            int m = Convert.ToInt32(Console.ReadLine());
            //Read vote details
            for (int i = 0; i < m; i++)
            {
                string candidate = Console.ReadLine();
                if (candidates.Contains(candidate))
                {
                    int index = candidate.IndexOf(candidate);
                    votes.Insert(index, votes[index] + 1);
                }
            }
            //Find max vote
            int maxVal = votes.Max();
            //Get winners list
            List<string> winners = new List<string>();
            for (int i = 0; i < votes.Count; i++)
            {
                if (votes[i] == maxVal)
                {
                    winners.Add(parties[i]);
                }
            }
            Console.WriteLine();
            //Check for tie
            if (winners.Count != 1)
            {
                Console.WriteLine("Tie");
            }
            //Otherwise
            else
            {
                Console.WriteLine(winners[0]);
            }
        }
    }
}