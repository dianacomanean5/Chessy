using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    [Serializable]
    public class Miscare
    {

        private int coloanaInitiala = 0;
        public int ColoanaInitiala
        {
            get
            {
                return coloanaInitiala;
            }

            set
            {
                coloanaInitiala = value;
            }
        }

        private int randInitial = 0;
        public int RandInitial
        {
            get
            {
                return randInitial;
            }

            set
            {
                randInitial = value;
            }
        }

        private int coloana = 0;
        public int Coloana
        {
            get
            {
                return coloana;
            }

            set
            {
                coloana = value;
            }
        }

        private int rand = 0;
        public int Rand
        {
            get
            {
                return rand;
            }

            set
            {
                rand = value;
            }
        }
    }
}
