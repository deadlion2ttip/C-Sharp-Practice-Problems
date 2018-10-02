using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAndLoopPractice
{
    class ArrayAndListPractice
    {

        static public void friendList()
        {
            var nameList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or nothing to end input");
                var input = Console.ReadLine();

                if (input == "")
                    break;
                else
                {
                    nameList.Add(input);
                }
            }

            if (nameList.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", nameList[0]);
            } else if(nameList.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", nameList[0], nameList[1]);
            } else if(nameList.Count > 2)
            {
                int moreFriends = nameList.Count - 2;
                Console.WriteLine("{0}, {1}, and {2} more like your post.", nameList[0], nameList[1], moreFriends);
            }
        }

        static public void reverseName()
        {
            Console.WriteLine("enter your name");

            string nameInput = Console.ReadLine();

            char [] nameArray = nameInput.ToCharArray();

            Array.Reverse(nameArray);

            Console.WriteLine(nameArray);

            string reverseName = String.Join("", nameArray);
       
            Console.WriteLine(reverseName);
        }

        static public void sortNumbers()
        {
            int[] numbers = new int[5];
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Enter a new number");

                int response = int.Parse(Console.ReadLine());

                if (Array.Exists(numbers, s => { return s == response; }))
                {
                    Console.WriteLine("Make sure you haven't entered that number already.\n");
                }
                else
                {
                    numbers[i] = response;
                    i++;
                }

            }

            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.Write(number);
            }
        }

        static public void onlyUnique()
        {
            var numbers = new List<int>();

            var doubles = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type quit");

                string response = Console.ReadLine();

                if (response == "quit" || response == "Quit")
                {
                    break;
                }
                else
                {
                    int numberEntered = int.Parse(response);

                    if (numbers.IndexOf(numberEntered) >= 0)
                        doubles.Add(numberEntered);
                    else
                    numbers.Add(numberEntered);
                }

            }

            foreach (int duplicate in doubles)
            {
                numbers.RemoveAll(i => { return i == duplicate; });
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
