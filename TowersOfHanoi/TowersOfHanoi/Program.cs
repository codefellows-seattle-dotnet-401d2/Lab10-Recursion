using System;

namespace TowersOfHanoi
{
    class Gameplay
    {
        public static int Main()
        {
            TowerOfHanoi Tower = new TowerOfHanoi();
            string userNumDiscs;

            Console.Write("Enter the number of discs you wish to play with: ");
            userNumDiscs = Console.ReadLine();
            Tower.Numdiscs = Convert.ToInt32(userNumDiscs);

            Tower.MoveTower(Tower.Numdiscs, 1, 3, 2);
            Console.ReadLine();

            return 0;
        }
    }
}
