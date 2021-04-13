using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    public class Rege:Piesa
    {
        public Rege(bool alb)
        {
            if (alb)
            {
                image = Properties.Resources.chess_piece_2_white_king;
                tip.id = 3;
            }
            else
            {
                image = Properties.Resources.chess_piece_2_black_king;
                tip.id = 4;
            }
        }
    }
}
