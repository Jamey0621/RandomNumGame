using System;

namespace RandomNumGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retry = true;
            Random random = new Random();
            do
            {
                int randomNumber = random.Next(1, 200);
                

                while (true)
                {
                    Console.Write("Guess any number between 1 and 200: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number < randomNumber)
                    {
                        Console.WriteLine("Too low, try agian!");
                       
                    }
                    else if (number > randomNumber)
                    {
                        Console.WriteLine("Too high, try agian!");
                       
                    }
                    else
                    {
                        Console.WriteLine("Great JOB YOU WINN!!");
                        Console.Write("Would you like to try agian? y/n: ");
                        string answer = Console.ReadLine();
                        if (answer != "y")
                        {
                            retry = false;
                        }
                        break;
                    }
                }
            }
            while (retry);
        }
    }
}
