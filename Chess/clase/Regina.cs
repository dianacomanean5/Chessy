using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
   public class Regina:Piesa
    {
       public Regina (bool alb){
           if(alb)
           {
               image = Properties.Resources.chess_piece_2_white_queen;
               tip.id = 5;
           }
           else
           {
               image = Properties.Resources.chess_piece_2_black_queen;
               tip.id = 6;
           }
   }

    }
}
