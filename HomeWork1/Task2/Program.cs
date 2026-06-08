namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name : ");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your age : ");
            var ageText = Console.ReadLine();
            if (int.TryParse(ageText, out var age) == false)
            {
                Console.WriteLine("Input age in not valid!");
                return;
            }

            Console.WriteLine($"Hello, {name}. You are {age} years old.");
                
        }
    }
}
