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

            string[] charArray = response.Split('-');

            int last = int.Parse(charArray[0]);

            bool consecutiveFlag = true;

            for (int i =1; i< charArray.Length; i++)
            {
                int currentInt = int.Parse(charArray[i]);
                if(currentInt - last == 1 || currentInt - last == -1)
                {
                    Console.WriteLine(currentInt - last);
                    last = currentInt;
                    continue;
                }

                Console.WriteLine(currentInt - last);
                consecutiveFlag = false;
                break;

            }

            if (consecutiveFlag)
            Console.WriteLine("Consecutive");

            else
                Console.WriteLine("not Consecutive");
        }
    }
}
