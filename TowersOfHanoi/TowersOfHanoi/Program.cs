using System;

namespace TowersOfHanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Towers of Hanoi!\nEnter a whole number to use as the starting number of disks:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Minimum number of moves\nUsing Recursion (Hanoi(n)): " + Hanoi(n));
            Console.WriteLine("Iteratively ((2^n)-1): " + (int)(Math.Pow(2,n)-1));
            Console.ReadLine();
        }

        public static int Hanoi(int n)
        {
            if (n == 1) return 1;
            return (2 * (Hanoi(n - 1)) + 1);
        }
    }
}
