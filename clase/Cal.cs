using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    public class Cal:Piesa
    {
        public Cal(bool alb) 
        {
            if (alb)
            {
                image = Properties.Resources.chess_piece_2_white_knight;
                tip.id = 1;
               
            }
            else
            {
                image = Properties.Resources.chess_piece_2_black_knight;
                tip.id = 2;
            }

        }
        public override void ColoreazaCelule(int coloana, int rand, Tabla tabla, bool[,] CeluleColorate)
        {
            try
            {
                CeluleColorate[coloana - 1, rand - 2] = true;

            }
            catch { }
            try
            {
                CeluleColorate[coloana - 2, rand + 1] = true;
            }
            catch { }
            try
            {
                CeluleColorate[coloana - 1, rand + 2] = true;
            }
            catch { }
            try
            {
                CeluleColorate[coloana + 1, rand + 2] = true;
            }
            catch { }
            try
            {
                CeluleColorate[coloana - 2, rand - 1] = true;
            }
            catch { }
            try
            {
                CeluleColorate[coloana + 2, rand - 1] = true;
            }
            catch { }
            try
            {
                CeluleColorate[coloana + 1, rand - 2] = true;
            }
            catch { }
        }
    }
}
