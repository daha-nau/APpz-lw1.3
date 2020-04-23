using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    public abstract class Game
    {
        public List<object> attributes;
        private Field field;
        private Facade facade;
        public List<Player> players;
        public abstract int makeMove(int player);
        public Game(int _players, string _field)
        {
            attributes = new List<object>();
            players = new List<Player>(_players);
            facade = new Facade();
            field = new Field(_field);
        }
        public void addAttributes(bool figure, int chip, bool checker, int cub)
        {
            facade.addAttributes(figure, chip, checker, cub, this.attributes);
        }
    }
}
