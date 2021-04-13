using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    [Serializable]
    public class RegulaTipPiesa
    {
        public RegulaTipPiesa(int coloana,int rand)
        {

            switch(Tabla.Table.board[coloana,rand].GetType().Name)
            {
                case "Cal":
                    Tabla.Table.board[coloana, rand].ColoreazaCelule(coloana, rand,  CeluleColorate);
                    break;
                case "Ofiter":

                    for (int i = 1; i < 7; i++)
                    {
                        try
                        {
                            if (Tabla.Table.board[coloana + i, rand + i] != null)
                            {
                                if (Tabla.Table.board[coloana + i, rand + i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - i, rand - i] != null)
                            {
                                if (Tabla.Table.board[coloana - i, rand - i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - i, rand + i] != null)
                            {
                                if (Tabla.Table.board[coloana - i, rand + i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana + i, rand - i] != null)
                            {
                                if (Tabla.Table.board[coloana + i, rand - i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                        break;
                case "Rege":
                        try
                        {
                            if (Tabla.Table.board[coloana + 1, rand] != null)
                            {
                                if (Tabla.Table.board[coloana + 1, rand].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - 1, rand] != null)
                            {
                                if(Tabla.Table.board[coloana - 1, rand].tip.id%2 != Tabla.Table.board[coloana, rand].tip.id%2)
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
                            if (Tabla.Table.board[coloana, rand+1] != null)
                            {
                                if (Tabla.Table.board[coloana , rand+1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                                {
                                    CeluleColorate[coloana, rand+1] = true;
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
                            if (Tabla.Table.board[coloana , rand-1] != null)
                            {
                                if (Tabla.Table.board[coloana , rand-1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                                {
                                    CeluleColorate[coloana, rand-1] = true;
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
                            if (Tabla.Table.board[coloana + 1, rand + 1] != null)
                            {
                                if (Tabla.Table.board[coloana + 1, rand + 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - 1, rand - 1] != null)
                            {
                                if (Tabla.Table.board[coloana - 1, rand - 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                                {
                                    CeluleColorate[coloana - 1, rand - 1] = true;
                                }
                            }
                            else
                            {
                            CeluleColorate[coloana - 1, rand - 1] = true;
                            }
                        }
                        catch {  }
                        try
                        {
                            if (Tabla.Table.board[coloana - 1, rand + 1] != null)
                            {
                                if (Tabla.Table.board[coloana - 1, rand + 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana + 1, rand - 1] != null)
                            {
                                if (Tabla.Table.board[coloana + 1, rand - 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                    break;
                case "Regina":
                    for (int i = 1; i < 8; i++)
                    {
                        try
                        {
                            if (Tabla.Table.board[coloana + i, rand] != null)
                            {
                                if (Tabla.Table.board[coloana + i, rand].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - i, rand] != null)
                            {
                                if(Tabla.Table.board[coloana - i, rand].tip.id%2 != Tabla.Table.board[coloana, rand].tip.id%2)
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
                            if (Tabla.Table.board[coloana, rand+i] != null)
                            {
                                if (Tabla.Table.board[coloana , rand+i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                                {
                                    CeluleColorate[coloana, rand+i] = true;
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
                            if (Tabla.Table.board[coloana , rand-i] != null)
                            {
                                if (Tabla.Table.board[coloana , rand-i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                                {
                                    CeluleColorate[coloana, rand-i] = true;
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
                    for (int i = 1; i < 7; i++)
                    {
                        try
                        {
                            if (Tabla.Table.board[coloana + i, rand + i] != null)
                            {
                                if (Tabla.Table.board[coloana + i, rand + i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - i, rand - i] != null)
                            {
                                if (Tabla.Table.board[coloana - i, rand - i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - i, rand + i] != null)
                            {
                                if (Tabla.Table.board[coloana - i, rand + i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana + i, rand - i] != null)
                            {
                                if (Tabla.Table.board[coloana + i, rand - i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                    break;

                case "Tura":
                    for (int i = 1; i < 8; i++)
                    {
                        try
                        {
                            if (Tabla.Table.board[coloana + i, rand] != null)
                            {
                                if (Tabla.Table.board[coloana + i, rand].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
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
                            if (Tabla.Table.board[coloana - i, rand] != null)
                            {
                                if(Tabla.Table.board[coloana - i, rand].tip.id%2 != Tabla.Table.board[coloana, rand].tip.id%2)
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
                            if (Tabla.Table.board[coloana, rand+i] != null)
                            {
                                if (Tabla.Table.board[coloana , rand+i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                                {
                                    CeluleColorate[coloana, rand+i] = true;
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
                            if (Tabla.Table.board[coloana , rand-i] != null)
                            {
                                if (Tabla.Table.board[coloana , rand-i].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                                {
                                    CeluleColorate[coloana, rand-i] = true;
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
                        break;
                case "Pion":
                    Jucator jucatorPropriu = VariabileGlobale.GetJucatorPropriu();
                    if ((jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 1) || (!jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 0))//daca am piesa proprie alba sau neagra directia e de jos in sus
                    {
                        try
                        {
                            if (Tabla.Table.board[coloana - 1, rand - 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana - 1, rand - 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (Tabla.Table.board[coloana + 1, rand - 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana + 1, rand - 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (Tabla.Table.board[coloana, rand - 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                            {
                                break;
                            }
                        }
                        catch { }
                    }
                    else if ((jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 != 1) || (!jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 != 0))
                    {
                        try
                        {
                            if (Tabla.Table.board[coloana - 1, rand + 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana - 1, rand + 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (Tabla.Table.board[coloana + 1, rand + 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana + 1, rand + 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (Tabla.Table.board[coloana, rand + 1].tip.id % 2 != Tabla.Table.board[coloana, rand].tip.id % 2)
                            {
                                break;
                            }
                        }
                        catch { }
                    }
                    if((jucatorPropriu.alb && Tabla.Table.board[coloana,rand].tip.id%2==1 && rand==5) ||(!jucatorPropriu.alb && Tabla.Table.board[coloana,rand].tip.id%2==0 && rand==5))
                    {
                        if (Tabla.Table.board[coloana, rand - 2]==null)
                        {
                            CeluleColorate[coloana, rand - 2] = true;
                        }
                        else if (Tabla.Table.board[coloana, rand - 2].tip.id % 2 == Tabla.Table.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana, rand - 2] = true;
                        }
                    }
                    else if ((jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 0 && rand == 1) || (!jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 1 && rand == 1))
                    {

                        if (Tabla.Table.board[coloana, rand + 2] == null)
                        {
                            CeluleColorate[coloana, rand + 2] = true;
                        }
                        else if (Tabla.Table.board[coloana, rand + 2].tip.id % 2 == Tabla.Table.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana, rand + 2] = true;
                        }
                    }

                    try
                    {
                        if ((jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 1 ) || (!jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 0 ))
                        {
                        
                            CeluleColorate[coloana, rand - 1] = true;
                        }
                        else if ((jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 0) || (!jucatorPropriu.alb && Tabla.Table.board[coloana, rand].tip.id % 2 == 1))
                        {
                            CeluleColorate[coloana, rand + 1] = true;
                        }
                    }
                    catch{}

                    break;
            }
        }

        public bool[,] CeluleColorate = new bool[8, 7];
    }
}
