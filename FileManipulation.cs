using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControlFlowAndLoopPractice
{
    public class FileManipulation
    {
        public static int numberOfWords(string path)
        {
           string fileText = File.ReadAllText(path);

            string[] fileWords = fileText.Split(new char[2] { ' ', '\n' });

            int wordCount = 0;

            foreach (string word in fileWords)
            {
                wordCount++;
            }

            return wordCount;
        }

        public static string longestWord(string path)
        {
            string fileText = File.ReadAllText(path);

            string[] fileWords = fileText.Split(new char[2] { ' ', '\n' });

            string longestWord = "";

            foreach (string word in fileWords)
            {
                if (longestWord.Length < word.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}
