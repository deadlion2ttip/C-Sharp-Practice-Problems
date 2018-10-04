using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAndLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CountByThrees.countByThree());

            //CountByThrees.sumUp();

            //CountByThrees.factorial();

            //CountByThrees.maximum();

            //ArrayAndListPractice.friendList();

            //ArrayAndListPractice.reverseName();

            //ArrayAndListPractice.sortNumbers();

            //ArrayAndListPractice.onlyUnique();

            //ArrayAndListPractice.threeSmallest();

            //StringManipulation.isConsecutive();

            //StringManipulation.areDuplicates();

            //StringManipulation.timeIsValid();

            //StringManipulation.PascalCase();

            //StringManipulation.numberOfVowels();

            string testFile = @"D:\Documents\Professional\Job hunting\Griffin.Resume.Software.txt";

            //Console.WriteLine(FileManipulation.numberOfWords(testFile));

            Console.WriteLine(FileManipulation.longestWord(testFile));
        }
    }
}
