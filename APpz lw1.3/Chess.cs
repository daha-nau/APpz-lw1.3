using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    public class Chess : Game
    {
        public Chess(int players, string fieldType = "chessboard") : base(players, fieldType)
        {
        }
        public override int makeMove(int player)
        {
            Random random = new Random();
            return random.Next(0, 15);
        }
    }
}
