using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{

    public class Ofiter:Piesa
    {
        public Ofiter(bool alb)
        {
            if (alb)
            {
                image = Properties.Resources.chess_piece_2_white_bishop;
                tip.id = 9;
            }
            else 
            {
                image=Properties.Resources.chess_piece_2_black_bishop;
                tip.id = 10;
            }

        }

    }
}
