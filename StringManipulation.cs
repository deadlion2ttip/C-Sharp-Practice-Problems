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
