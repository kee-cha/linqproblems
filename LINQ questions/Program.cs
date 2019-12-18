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
            List<Word> words = new WordList().GetWord();
            List<Word> wordsWithTh = words.FindAll(w => w.title.Contains("th"));
            foreach (var newWord in wordsWithTh)
            {
                Console.WriteLine(newWord.title);
            }
            Console.ReadLine();
        }
    }
}
