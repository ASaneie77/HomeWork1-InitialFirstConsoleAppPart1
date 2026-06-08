using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            bool guessValidFlag = false;

            #region While Loop
            int randNumber = rand.Next(1, 10);

            Console.WriteLine("You should guess a number between 1 and 10");
            Console.WriteLine("Please enter your number : ");
            while (true)
            {
                var numStr = Console.ReadLine();

                if (int.TryParse(numStr, out int guessNum))
                {
                    if (randNumber == guessNum)
                    {
                        Console.WriteLine("Congradulation! Your guess is correct!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your guess isn't correct, Please guess again : ");
                    }
                }
                else
                {
                    Console.WriteLine("Input value is invalid!, Please guess again : ");
                }
            }
            #endregion

            #region For Loop
            randNumber = rand.Next(1, 10);

            Console.WriteLine("\nNow,You have 5 attempts to guess number between 1 and 10.");
            for (int i = 0; i < 5; i++)
            {
                var numStr = Console.ReadLine();

                if (int.TryParse(numStr, out int guessNum))
                {
                    if (randNumber == guessNum)
                    {
                        Console.WriteLine("Congradulation! Your guess is correct!");
                        guessValidFlag = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your guess isn't correct, Please guess again : ");
                    }
                }
                else
                {
                    Console.WriteLine("Input value is invalid!, Please guess again : ");
                }
            }

            if (guessValidFlag == false)
            {
                Console.WriteLine($"Sorry, You cann't guess correct. number is {randNumber}");
            }
            #endregion
        }
    }
}
