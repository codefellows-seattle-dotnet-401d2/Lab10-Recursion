using System;

namespace Hanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("How many discs are we using today?");
                string input = Console.ReadLine(); ### Gets skipped on subsequent iterations?
                Console.Clear();

                if ( Int32.TryParse(input, out int output))
                {
                    validNumber = true;
                    int moves = Hanoi(output);
                    int movesI = HanoiI(output);

                    Console.WriteLine($"Recursive method got {moves} moves, iterative returned {movesI}.");
                    Console.WriteLine("Press Enter to exit.");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("That's not a valid integer. Try again?");
                    input = null;
                    Console.Read();
                    Console.Clear();
                }
            }
        }

        public static int Hanoi(int discs)
        {
            return Power(2, discs) - 1;
        }

        public static int HanoiI(int discs)
        {
            return PowerI(2, discs) - 1;
        }

        public static int Power(int of, int power)
        {   
            if(power > 1)
            {
                return of * Power(of, power - 1);
            }
            else
            {
                return of;
            }
        }

        public static int PowerI(int of, int power)
        {
            int newof = of;
            for(int i = power; i > 1; i--)
            {
                newof = newof * of;
            }
            return newof;
        }
    }
}
