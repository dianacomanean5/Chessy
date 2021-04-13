using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
     public class Tura:Piesa
    {
        public Tura()
        {
        }

        public  Tura (bool alb)
        {
            if (alb)
            {
                image = Properties.Resources.chess_piece_2_white_rook;
                tip.id = 7;
            }
            else
            {
                image = Properties.Resources.chess_piece_2_black_rook;
                tip.id = 8;
            }
        }
    }
}
