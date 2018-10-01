using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAndLoopPractice
{
    class CountByThrees
    {
        static public int countByThree()
        {
            int total = 0;
            for (int count = 1; count <= 100; count ++)
            {
                if (count%3 == 0)
                {
                    total++;
                }
            }
            return total;
        }

        static public void sumUp()
        {
            int total = 0;
            while (true)
            {
                Console.Write("Enter a number or 'ok': ");
                var response = Console.ReadLine();

                if (response == "ok"|| response == "OK")
                {
                    break;
                }else
                {
                    total += int.Parse(response);
                }
            }

            Console.WriteLine(total);
        }

        static public void factorial()
        {
            Console.Write("Factorial! Enter a number: ");
            var response = Console.ReadLine();

            int num = int.Parse(response);

            int result = 1;

            for (int i = num; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine("{0}! = {1}", num, result);
        }

        static public void maximum()
        {
            Console.Write("Enter a list of numbers separated by commas: ");
            var response = Console.ReadLine();

            string[] split = response.Split(',');

            Console.WriteLine(split);

            int max = 0;
            foreach (string number in split)
            {
                int parsed = int.Parse(number);

                if (parsed > max)
                {
                    max = parsed;
                }
            }

            Console.WriteLine("max is: {0}", max);
        }
    }
}
