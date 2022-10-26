using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrokodilleSpill
{
    internal class DrawGame
    {
        public static int Tall1 { get; set; }
        public static int Tall2 { get; set; }

        public static void DrawBoard() 
        {
            Random rnd = new Random();
            Tall1 = rnd.Next(1, 12);
            Tall2 = rnd.Next(1, 12);
            Console.WriteLine(Tall1 + "_" + Tall2);
        }

    }
}
