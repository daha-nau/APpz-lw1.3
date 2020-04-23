using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    public class Backgammon : Game
    {
        private int[] sum;
        public Backgammon(int players, string fieldType = "chessboard") : base(players, fieldType)
        {
            sum = new int[2];
            sum[0] = 0;
            sum[1] = 0;
        }
        public override int makeMove(int player)
        {
            int result = ((Cub)attributes[0]).getSide() + ((Cub)attributes[1]).getSide();
            sum[player] += result;
            return result;
        }
        public int getSum(int player) => sum[player];
    }
}
