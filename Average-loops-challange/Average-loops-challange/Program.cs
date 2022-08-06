using System;

namespace Average_loops_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toltalScore = 0;
            string inputScore = "0";
            int count = 0;
            int currentNumber = 0;

            while(inputScore != "-1")
            {
                Console.WriteLine("last number was {0}", currentNumber);
                Console.WriteLine("Current amount of entries: {0}", count);
                Console.WriteLine("Enter -1 when you're ready to calculate the average");
                Console.WriteLine("Enter the new score: ");
                
                inputScore = Console.ReadLine();
                if(inputScore.Equals("-1") && count != 0)
                {
                    Console.WriteLine("----------------------------------------------");
                    double average = (double)toltalScore / (double)count;
                    Console.WriteLine("The average score is {0}", average);
                }
                if(int.TryParse(inputScore, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    toltalScore += currentNumber;
                }
                else
                {
                    if (!(inputScore.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }
                count++;
            }
            Console.Read();
        }
    }
}
