namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            if (FirstMethod() || SecondMethod() || ThirdMethod())
            {
                Console.WriteLine("Both are true");
            }
            else
            {
                Console.WriteLine("Both are not true");
            }
        }

        static bool FirstMethod()
        {
            Console.WriteLine("Hello From First Method");
            return false;
        }

        static bool SecondMethod()
        {
            Console.WriteLine("Hello From Second Method");
            return true;
        }

        static bool ThirdMethod()
        {
            Console.WriteLine("Hello From Third Method");
            return true;
        }


    }
}