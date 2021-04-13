using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    [Serializable]
    public class TipPiesa
    {
        public TipPiesa()
        {
            reguli = new List<RegulaTipPiesa>();
            id = 0;
        }
        public List<RegulaTipPiesa> reguli;
        public int id;
        public string denumire;
    }
}
