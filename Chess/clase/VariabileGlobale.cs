using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    public static class VariabileGlobale
    {
        public static List<Jucator> jucatori = new List<Jucator>();

        public static Jucator GetJucatorPropriu()
        {
            for(int i=0;i<jucatori.Count;i++)
            {
                if(jucatori[i].propriu)
                {
                    return jucatori[i];
                }
            }
            return new Jucator();
        }
    }
}
