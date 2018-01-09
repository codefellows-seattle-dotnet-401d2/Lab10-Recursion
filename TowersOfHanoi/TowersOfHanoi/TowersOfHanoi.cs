using System;
using System.Collections.Generic;
using System.Text;

namespace TowersOfHanoi
{
    class TowerOfHanoi
    {
        int discs;

        public TowerOfHanoi()
        {
            Numdiscs = 0;
        }

        public TowerOfHanoi(int newVal)
        {
            Numdiscs = newVal;
        }

        public int Numdiscs
        {
            get
            {
                return discs;
            }
            set
            {
                if (value > 0)
                    discs = value;
            }
        }

        public void MoveTower(int n, int from, int to, int vacant)
        {
            if (n > 0)
            {
                MoveTower(n - 1, from, vacant, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                MoveTower(n - 1, vacant, to, from);
            }
        }
    }
}

