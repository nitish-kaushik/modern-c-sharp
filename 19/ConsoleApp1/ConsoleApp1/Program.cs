namespace ConsoleApp1
{
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.Append("Nitish ");
            }

            Console.WriteLine(sb.ToString());

            sb.Insert(10, "AAAA");

            sb.Replace("Nitish","Kaushik");

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"Capacity = {sb.Capacity}");
            Console.WriteLine($"MaxCapacity = {sb.MaxCapacity}");
            Console.WriteLine($"Length = {sb.Length}");
        }
    }
}