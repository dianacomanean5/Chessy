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
        public RegulaTipPiesa(int coloana,int rand,Tabla tabla)
        {

            switch(tabla.board[coloana,rand].GetType().Name)
            {
                case "Cal":
                    tabla.board[coloana, rand].ColoreazaCelule(coloana, rand, tabla, CeluleColorate);
                    break;
                case "Ofiter":
                    tabla.board[coloana, rand].ColoreazaCelule(coloana, rand, tabla, CeluleColorate);
                    
                        break;
                case "Rege":
                        tabla.board[coloana, rand].ColoreazaCelule(coloana, rand, tabla, CeluleColorate);
                        
                    break;
                case "Regina":
                    tabla.board[coloana, rand].ColoreazaCelule(coloana, rand, tabla, CeluleColorate);
                    
                    break;

                case "Tura":
                    tabla.board[coloana, rand].ColoreazaCelule(coloana, rand, tabla, CeluleColorate);
                    
                        break;
                case "Pion":
                    Jucator jucatorPropriu = VariabileGlobale.GetJucatorPropriu();
                    if ((jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 1) || (!jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 0))//daca am piesa proprie alba sau neagra directia e de jos in sus
                    {
                        try
                        {
                            if (tabla.board[coloana - 1, rand - 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana - 1, rand - 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (tabla.board[coloana + 1, rand - 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana + 1, rand - 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (tabla.board[coloana, rand - 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                            {
                                break;
                            }
                        }
                        catch { }
                    }
                    else if ((jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 != 1) || (!jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 != 0))
                    {
                        try
                        {
                            if (tabla.board[coloana - 1, rand + 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana - 1, rand + 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (tabla.board[coloana + 1, rand + 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                            {
                                CeluleColorate[coloana + 1, rand + 1] = true;
                            }
                        }
                        catch { }
                        try
                        {
                            if (tabla.board[coloana, rand + 1].tip.id % 2 != tabla.board[coloana, rand].tip.id % 2)
                            {
                                break;
                            }
                        }
                        catch { }
                    }
                    if((jucatorPropriu.alb && tabla.board[coloana,rand].tip.id%2==1 && rand==5) ||(!jucatorPropriu.alb && tabla.board[coloana,rand].tip.id%2==0 && rand==5))
                    {
                        if (tabla.board[coloana, rand - 2]==null)
                        {
                            CeluleColorate[coloana, rand - 2] = true;
                        }
                        else if (tabla.board[coloana, rand - 2].tip.id % 2 == tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana, rand - 2] = true;
                        }
                    }
                    else if ((jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 0 && rand == 1) || (!jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 1 && rand == 1))
                    {

                        if (tabla.board[coloana, rand + 2] == null)
                        {
                            CeluleColorate[coloana, rand + 2] = true;
                        }
                        else if (tabla.board[coloana, rand + 2].tip.id % 2 == tabla.board[coloana, rand].tip.id % 2)
                        {
                            CeluleColorate[coloana, rand + 2] = true;
                        }
                    }

                    try
                    {
                        if ((jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 1 ) || (!jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 0 ))
                        {
                        
                            CeluleColorate[coloana, rand - 1] = true;
                        }
                        else if ((jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 0) || (!jucatorPropriu.alb && tabla.board[coloana, rand].tip.id % 2 == 1))
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
