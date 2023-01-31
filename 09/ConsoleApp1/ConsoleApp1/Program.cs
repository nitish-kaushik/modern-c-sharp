namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object rollNumber = 10;

            int firstRollNumber = Convert.ToInt32(rollNumber);

            rollNumber = 123;

            object firstName, lastName;
            bool isPermanent;

            firstName = "Nitish";
            firstName = 123;
            firstName = true;


            isPermanent = true;
            isPermanent = false;


            rollNumber = firstName;


            var userInput = Console.ReadLine();
        }
    }
}