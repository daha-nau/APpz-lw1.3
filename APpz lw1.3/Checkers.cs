using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    public class Checkers : Game
    {
        public Checkers(int players, string fieldtype = "chessboard") : base(players, fieldtype)
        {
        }

        public override int makeMove(int player)
        {
            Random random = new Random();
            return ((Checker)attributes[random.Next(0, 15)]).Identifier;
        }
    }
}
