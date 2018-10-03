using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAndLoopPractice
{
    public class StringManipulation
    {
        private static string solicitInput(string requiredInput)
        {
            Console.Write("Please Enter {0}: ", requiredInput);
            return Console.ReadLine().Trim();
        }

        public static void numberOfVowels()
        {
            string response = solicitInput("an english word: ");

            char[] letters = response.ToLower().ToCharArray();

            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            int vowelCount = 0;

            foreach (char letter in letters)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }

        static public void PascalCase()
        {
            string response = solicitInput("a phrase: ");

            string[] words = response.Split(' ');

            var variableName = new StringBuilder();

            foreach (string word in words)
            {
                var capitalizedWord = new StringBuilder();
                capitalizedWord.Append(word.ToUpper()[0]);
                Console.WriteLine(capitalizedWord);
                capitalizedWord.Append(word.ToLower().Substring(1));
                Console.WriteLine(capitalizedWord);

                variableName.Append(capitalizedWord);
            }

            Console.WriteLine(variableName);
        }

        static public void timeIsValid()
        {
            string response = solicitInput("a 24-hour time (15:37)");

            StringBuilder output = new StringBuilder("invalid time");

            if (string.IsNullOrWhiteSpace(response))
                goto Finish;

            string[] responseArray = response.Split(':');

            if (validHour(responseArray[0]) && validMinute(responseArray[1]))
                output = new StringBuilder("Valid Time");

            Finish:
            Console.WriteLine(output);
        }

        static private bool validHour(string hour)
        {
            int parsedHour = int.Parse(hour);

            return (parsedHour >= 0 && parsedHour < 24);
        }

        static private bool validMinute(string minute)
        {
            int parsedHour = int.Parse(minute);

            return (parsedHour >= 0 && parsedHour < 60);
        }

        static public void areDuplicates()
        {
           string response = solicitInput("numbers separated by hyphens");

            string[] numberArray = response.Split('-');

            var seenList = new List<string>();

            foreach (string number in numberArray)
            {
                if (seenList.Contains(number))
                {
                    Console.WriteLine("Duplicate");
                    break;
                }

                seenList.Add(number);
            }
        }

        static public void isConsecutive()
        {
            string response = solicitInput("hyphen separated numbers");
            countsUp(response);

            if (countsUp(response) || countsDown(response))
                Console.WriteLine("Consecutive");

            else
                Console.WriteLine("not Consecutive");
        }

        private static bool countsUp(string response)
        {
            string[] charArray = response.Split('-');

            int first = int.Parse(charArray[0]);

            bool consecutiveFlag = true;

            for (int i = 1; i < charArray.Length; i++)
            {
                int currentInt = int.Parse(charArray[i]);
                if (currentInt - first == i)
                {
                    Console.WriteLine(currentInt - i);
                   
                    continue;
                }

                Console.WriteLine(currentInt - i);
                consecutiveFlag = false;
                break;

            }

            return consecutiveFlag;
        }

        private static bool countsDown(string response)
        {
            string[] charArray = response.Split('-');

            int first = int.Parse(charArray[0]);

            bool consecutiveFlag = true;

            for (int i = 1; i < charArray.Length; i++)
            {
                int currentInt = int.Parse(charArray[i]);
                if (currentInt - first == -i)
                {
                    Console.WriteLine(currentInt - i);
                   
                    continue;
                }

                Console.WriteLine(currentInt - i);
                consecutiveFlag = false;
                break;

            }

            return consecutiveFlag;
        }

    }
}
