using System;
using System.Collections.Generic;

namespace FrequentWordConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter URL to read");
            string URL = Console.ReadLine();

            if (URL.Length > 0)
            {
                URLFetcher uf = new URLFetcher();
                string urlText = uf.GetURLText(URL);

                if (urlText.Length > 0)
                {
                    WordCollector wc = new WordCollector();
                    char[] delimeters = {' '};
                    Dictionary<string,long> words = wc.GetWords(urlText,delimeters);

                    if (words.Keys.Count > 0)
                    {
                        WordRanker wr = new WordRanker();
                        List<KeyValuePair<string, long>> rankedWords = wr.RankWords(words, 10);

                        Console.WriteLine("Top 10 Words:");

                        foreach (KeyValuePair<string,long> word in rankedWords)
                        {
                            Console.WriteLine($"Word: {word.Key}  Count: {word.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No words retrieved from URL: " + URL);
                    }
                }
                else
                {
                    Console.WriteLine("No text retrieved from URL: " + URL);
                }
                

            }
            else
            {
                Console.WriteLine("Invalid URL");
            }

            Console.ReadLine();
        }
    }
}
