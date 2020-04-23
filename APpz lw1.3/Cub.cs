using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    public class Cub
    {
        private int[] side;
        public Cub()
        {
            side = new int[6];
            for (int i = 0; i < 6; i++)
            {
                side[i] = i + 1;
            }
        }
        public int getSide()
        {
            Random random = new Random();
            return side[random.Next(0, 5)];
        }
    }
}
