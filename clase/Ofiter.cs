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
                image = Properties.Resources.chess_piece_2_black_bishop;
                tip.id = 10;
            }
        }
            public override void ColoreazaCelule(int coloana, int rand, Tabla tabla, bool[,] CeluleColorate)
        {
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (tabla.board[coloana + i, rand + i] != null)
                    {
                        if (tabla.board[coloana + i, rand + i].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana + i, rand + i] = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        CeluleColorate[coloana + i, rand + i] = true;
                    }
                }
                catch { break; }
            }
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (tabla.board[coloana - i, rand - i] != null)
                    {
                        if (tabla.board[coloana - i, rand - i].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana - i, rand - i] = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        CeluleColorate[coloana - i, rand - i] = true;
                    }
                }
                catch { break; }
            }
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (tabla.board[coloana - i, rand + i] != null)
                    {
                        if (tabla.board[coloana - i, rand + i].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana - i, rand + i] = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        CeluleColorate[coloana - i, rand + i] = true;
                    }
                }
                catch { break; }
            }
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (tabla.board[coloana + i, rand - i] != null)
                    {
                        if (tabla.board[coloana + i, rand - i].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana + i, rand - i] = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        CeluleColorate[coloana + i, rand - i] = true;
                    }

                }
                catch { break; }
            }
        }

    }
}
