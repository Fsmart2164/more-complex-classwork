using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dictionarys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> inventory = new Dictionary<string,int>();
            inventory.Add("health potion", 10);

            // word count
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in wordCounts)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }

            Console.ReadKey();
            Console.Clear();

            // letter count
            Dictionary<char,int> lettercounts = new Dictionary<char,int>();
            string insert = File.ReadAllText("bee movie.txt");
            foreach (char letter in insert)
            {
                if (letter != ' '&& letter != '\r' && letter != '\n')
                {
                    if (lettercounts.ContainsKey(letter))
                    {
                        lettercounts[letter]++;
                    }
                    else
                    {
                        lettercounts.Add(letter, 1);
                    }
                }
            }

            foreach (KeyValuePair<char, int> pair in lettercounts)
            {
                Console.Write(pair.Key+" : "+pair.Value+", ");
            }
            Console.ReadKey(true);
        }
    }
}
