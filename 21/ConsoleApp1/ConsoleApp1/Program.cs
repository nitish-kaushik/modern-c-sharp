namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "My full name is Nitish Kaushik";

            bool result = fullName.Contains("niTisH", StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine(result);
        }
    }
}