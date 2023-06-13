namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           object obj = null;
            obj = 1m;
            //obj = true;
            //obj = "Nitish Kaushik";
            //obj = new { FirstName = "Nitish", LastName = "Kaushik" };

            //string name = obj.ToString();

            Console.WriteLine($"The value of object is {obj} and the type is {obj.GetType()}");
        }
    }
}