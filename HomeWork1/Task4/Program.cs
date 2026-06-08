namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guessCntr = 0;
            string secretKey = "Amir";

            Console.WriteLine("You should guess a secret word!");
            Console.WriteLine("Please enter your word : ");

            while (true)
            {
                guessCntr++;
                var guessWord = Console.ReadLine();

                if(guessWord == secretKey)
                {
                    Console.WriteLine("Congratulations!You guess correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry! Your guess isn't correct.Please enter again : ");
                }
            }

            Console.WriteLine($"You guess secret word in {guessCntr} attempts");
        }
    }
}
