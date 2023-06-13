namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IntPtr myVar1 = 10;
            nint myVar2 = 10;

            System.UIntPtr myVar3 = 10;
            nuint myVar4 = 10;

            Console.WriteLine($"Size of System.IntPtr {nint.Size}");
            Console.WriteLine($"MaxValue of System.IntPtr {nint.MaxValue}");
            Console.WriteLine($"MinValue of System.IntPtr {nint.MinValue}");


            Console.WriteLine($"Size of System.UIntPtr {nuint.Size}");
            Console.WriteLine($"MaxValue of System.UIntPtr {nuint.MaxValue}");
            Console.WriteLine($"MinValue of System.UIntPtr {nuint.MinValue}");

        }
    }
}