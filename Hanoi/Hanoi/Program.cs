using System;

// add tests

namespace Hanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Towers of Hanoi");
            int moves = RecursiveHanoi(4);
            Towers(4, 1, 2, 3);
            Console.WriteLine("Total Number of Moves: " + moves);
            
            Console.ReadLine();
        }

        // Towers of Hanoi Recursive solution
        public static int RecursiveHanoi(int n)
        {
            if (n == 1) return 1;
            else
            {
                return (2 * RecursiveHanoi(n - 1) + 1);
            }
        }

        // Output each move
        public static void Towers(int n, int from, int to , int middle)
        {
            if (n > 0)
            {
                Towers(n - 1, from, middle, to);
                Console.WriteLine("Move n {0} from tower {1} to tower {2}", n, from, to); 
                Towers(n - 1, middle, to, from);
            } 
        }
    }
}
