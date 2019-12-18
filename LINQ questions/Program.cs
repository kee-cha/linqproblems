using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> wordsWithTh = words.FindAll(w => w.Contains("th"));
            foreach (var newWord in wordsWithTh)
            {
                Console.WriteLine(newWord);
            }

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            List<string> distinctNames = names.Distinct().ToList();
            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
