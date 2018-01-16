using System.Collections.Generic;

namespace FrequentWordConsole
{
    class WordCollector
    {
        public Dictionary<string, long> GetWords(string input, char[] delimiters)
        {
            Dictionary<string,long> words = new Dictionary<string, long>();

            if (input.Length > 0 && delimiters.Length > 0)
            {
                string[] splitWords = input.Split(delimiters);

                foreach (string word in splitWords )
                {
                    if (words.ContainsKey(word))
                    {
                        words[word]++;
                    }
                    else
                    {
                        words.Add(word,1);
                    }
                }
            }

            return words;

        }
    }
}
