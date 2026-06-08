namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;
            int sumNumbers = 0;

            Console.WriteLine("Please enter a positive, integer number : ");

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputNumber))
                {
                    if(inputNumber >= 1)
                    {
                        break;
                    }

                    Console.WriteLine("Input number is not valid.Please enter number again : ");
                }
                else
                {
                    Console.WriteLine("Input number is not valid.Please enter number again : ");
                }
            }

            for (int i = 1; i <= inputNumber; i += 1)
            {
                if (i % 2 != 0)
                    sumNumbers += i;
            }

            /*
            for (int i = 1; i <= inputNumber; i += 2)
            {
                sumNumbers += i;
            }
            */

            Console.WriteLine($"Sum of odd numbers from 1 to {inputNumber} is : {sumNumbers}");
        }
    }
}
