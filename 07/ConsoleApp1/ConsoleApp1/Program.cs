namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key");

            //int userInput;

            //do
            //{
            //    userInput = Console.Read();
            //    Console.WriteLine(Convert.ToChar(userInput));
            //} while (userInput != 65);

            var userInput = Console.ReadKey();

            Console.WriteLine(userInput.KeyChar);

        }
    }
}