using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
  class Pion:Piesa
    {
        public Pion(bool alb)
        {
            if (alb)
            {
                image = Properties.Resources.chess_piece_2_white_pawn;
                tip.id = 9;
            }
            else
            {
                image = Properties.Resources.chess_piece_2_black_pawn;
                tip.id = 10;
            }
        }
    }
}  
    
        
    

