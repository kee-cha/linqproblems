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
            //question 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> wordsWithTh = words.FindAll(w => w.Contains("th"));
            foreach (var newWord in wordsWithTh)
            {
                Console.WriteLine(newWord);
            }
            //question 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            List<string> distinctNames = names.Distinct().ToList();
            foreach (var item in distinctNames)
            {
                Console.WriteLine(item);
            }
            //question 3
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
        
            var newClassGrade = classGrades.Select(c => c.Split(',').Select(n =>Convert.ToInt32(n)).OrderByDescending(n=>n).Take(c.Split(',').Length-1).Average()).Average();
            Console.WriteLine(newClassGrade);

            //question 4
            string name = "Terrill";
                var nameArry = name.ToUpper().ToArray().OrderBy(n=>n);
                var result = nameArry.GroupBy(n => n).Select(n =>$"{n.Last()}{n.Count()}");
            string finalResult = "";
                foreach (var letter in result)
                {
                    finalResult+= letter.ToString();
                }
                Console.WriteLine(finalResult);
            Console.ReadLine();

        }
    }
}
