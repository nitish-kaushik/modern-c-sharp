namespace UserInputApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, What is your name");

            var input = Console.ReadLine();

            Console.WriteLine($"Your name is {input}.");

            Console.WriteLine("Hello there, What is college name");

            input = Console.ReadLine();

            Console.WriteLine($"Your college name is {input}.");
        }
    }
}