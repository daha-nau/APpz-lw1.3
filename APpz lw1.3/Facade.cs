using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    public class Facade
    {
        public Facade() 
        {    }
        public void addAttributes(bool figure, int chip, bool checker, int cub, List<object> attributes)
        {
            if(figure == true)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (i < 8)
                        attributes.Add(new Figure("pawn"));
                    else if (i < 10)
                        attributes.Add(new Figure("rook"));
                    else if (i < 12)
                        attributes.Add(new Figure("knight"));
                    else if (i < 14)
                        attributes.Add(new Figure("bishop"));
                    else if (i == 14)
                        attributes.Add(new Figure("queen"));
                    else attributes.Add(new Figure("king"));
                }
            }
            for(int i = 0; i < chip; i++)
            {
                attributes.Add(new Chip(i));
            }
            if(checker == true)
            {
                for (int i = 0; i < 16; i++)
                {
                    attributes.Add(new Checker(i + 1));
                }
            }
            for(int i = 0; i < cub; i++)
            {
                attributes.Add(new Cub());
            }
        }
    }
}
