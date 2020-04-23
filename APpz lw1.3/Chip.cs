using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    enum Colour { red, orange, yellow, green, blue, violet };
    public class Chip
    {
        private Colour Color { get; set; }
        public Chip(int pos)
        {
            Color = (Colour)pos;
        }
    }
}
