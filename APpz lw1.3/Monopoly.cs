using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    class Monopoly : Game
    {
        private int[] position;
        public Monopoly(int players, string fieldType = "monopoly board") : base(players, fieldType)
        {
            position = new int[players];
            for (int i = 0; i < players; i++)
            {
                position[i] = 0;
            }
        }
        public override int makeMove(int player)
        {
            position[player] += ((Cub)attributes[position.Length]).getSide() + ((Cub)attributes[position.Length + 1]).getSide();
            position[player] = position[player] % 30;
            return position[player];
        }
    }
}
