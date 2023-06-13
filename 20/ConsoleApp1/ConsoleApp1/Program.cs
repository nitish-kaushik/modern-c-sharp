namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nitish";
            string lastName = "Kaushik";
            DateTime dateTime = DateTime.Now;

            string fullName = $"My first name is {firstName}, and the last name is {lastName} and the time is {dateTime:dd}" + "this is second";
            

            Console.WriteLine(fullName);
        }
    }
}