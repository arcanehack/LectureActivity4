using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LectureActivity4
{
    class AnalyzeString
    {
        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            StringAnalysis analysis = new StringAnalysis();
            
            Thread digitThread = new Thread(() => analysis.upperCountThread(str));
            Thread upperThread = new Thread(() => analysis.DigitCountThread(str));
            Thread palThread = new Thread(() => analysis.isPalindromeThread(str));

            digitThread.Start();
            upperThread.Start();
            palThread.Start();
            digitThread.Join();
            upperThread.Join();
            palThread.Join();

            Console.WriteLine("Digit count: " + analysis.getDigitCount() + "\n" +
                            "Upper count: " + analysis.getUpperCount() + "\n" +
                            "Is it a palindrome: " + analysis.getPalindrome());
        }
    }


}
