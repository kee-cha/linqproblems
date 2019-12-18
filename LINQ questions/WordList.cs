using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_questions
{
    public class WordList
    {
        public List<Word> GetWord()
        {
            return new List<Word>() {
                new Word(){title = "the"},
                new Word(){title = "bike" },
                new Word(){title = "this" },
                new Word(){title =  "it"},
                new Word(){title = "tenth" },
                new Word(){title = "mathematics"}
            };
        }
    }
}
