using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    public class Rege : Piesa
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
        public override void ColoreazaCelule(int coloana, int rand, Tabla tabla, bool[,] CeluleColorate)
        {
            try
            {
                if (tabla.board[coloana + 1, rand] != null)
                {
                    if (tabla.board[coloana + 1, rand].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana + 1, rand] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana + 1, rand] = true;
                }
            }
            catch { }
            try
            {
                if (tabla.board[coloana - 1, rand] != null)
                {
                    if (tabla.board[coloana - 1, rand].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana - 1, rand] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana - 1, rand] = true;
                }
            }
            catch { }
            try
            {
                if (tabla.board[coloana, rand + 1] != null)
                {
                    if (tabla.board[coloana, rand + 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana, rand + 1] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana, rand + 1] = true;
                }
            }
            catch { }
            try
            {
                if (tabla.board[coloana, rand - 1] != null)
                {
                    if (tabla.board[coloana, rand - 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana, rand - 1] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana, rand - 1] = true;
                }
            }
            catch { }
            try
            {
                if (tabla.board[coloana + 1, rand + 1] != null)
                {
                    if (tabla.board[coloana + 1, rand + 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana + 1, rand + 1] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana + 1, rand + 1] = true;
                }
            }
            catch { }
            try
            {
                if (tabla.board[coloana - 1, rand - 1] != null)
                {
                    if (tabla.board[coloana - 1, rand - 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana - 1, rand - 1] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana - 1, rand - 1] = true;
                }
            }
            catch { }
            try
            {
                if (tabla.board[coloana - 1, rand + 1] != null)
                {
                    if (tabla.board[coloana - 1, rand + 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana - 1, rand + 1] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana - 1, rand + 1] = true;
                }
            }
            catch { }
            try
            {
                if (tabla.board[coloana + 1, rand - 1] != null)
                {
                    if (tabla.board[coloana + 1, rand - 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                    {
                        CeluleColorate[coloana + 1, rand - 1] = true;
                    }
                }
                else
                {
                    CeluleColorate[coloana + 1, rand - 1] = true;
                }

            }
            catch { }
        }
    }
}