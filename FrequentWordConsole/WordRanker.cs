using System.Collections.Generic;
using System.Linq;

namespace FrequentWordConsole
{
    class WordRanker
    {
        public Dictionary<string,long> RankWords(Dictionary<string, long> words, int rank)
        {
            Dictionary<string,long> returnDictionary = new Dictionary<string, long>();

            if (words.Keys.Count > 0 && rank > 0)
            {
                var sortedWords = words.ToList();
                sortedWords.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

                returnDictionary = (Dictionary<string, long>) sortedWords.Take(rank);
            }

            return returnDictionary;
        }
    }
}
