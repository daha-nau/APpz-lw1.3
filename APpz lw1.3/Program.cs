using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                menu.start();
                Console.Read();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                Console.Read();
            }
        }
    }
}
