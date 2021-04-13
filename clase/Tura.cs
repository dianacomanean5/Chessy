using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    class Tura : Piesa
    {
        public Tura(bool alb)
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
        public override void ColoreazaCelule(int coloana, int rand, Tabla tabla, bool[,] CeluleColorate)
        {
            for (int i = 1; i < 8; i++)
            {
                try
                {
                    if (tabla.board[coloana + i, rand] != null)
                    {
                        if (tabla.board[coloana + i, rand].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana + i, rand] = true;
                        }
                        break;
                    }
                    else
                    {
                        CeluleColorate[coloana + i, rand] = true;
                    }
                }
                catch { }
            }
            for (int i = 1; i < 8; i++)
            {
                try
                {
                    if (tabla.board[coloana - i, rand] != null)
                    {
                        if (tabla.board[coloana - i, rand].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana - i, rand] = true;
                        }
                        break;
                    }
                    else
                    {
                        CeluleColorate[coloana - i, rand] = true;
                    }
                }
                catch { }
            }
            for (int i = 1; i < 8; i++)
            {
                try
                {
                    if (tabla.board[coloana, rand + i] != null)
                    {
                        if (tabla.board[coloana, rand + i].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana, rand + i] = true;
                        }
                        break;
                    }
                    else
                    {
                        CeluleColorate[coloana, rand + i] = true;
                    }
                }
                catch { }
            }
            for (int i = 1; i < 8; i++)
            {
                try
                {
                    if (tabla.board[coloana, rand - i] != null)
                    {
                        if (tabla.board[coloana, rand - i].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana, rand - i] = true;
                        }
                        break;
                    }
                    else
                    {
                        CeluleColorate[coloana, rand - i] = true;
                    }
                }
                catch { }
            }
        }
    }
}