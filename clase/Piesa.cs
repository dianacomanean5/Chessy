using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess.clase
{
    [Serializable]
    public class Piesa
    {
        public Piesa()
        {
            tip = new TipPiesa();
        }
        public int x;
        public int y;
        public Image image;
        public TipPiesa tip;

        public virtual void ColoreazaCelule(int coloana, int rand, Tabla tabla,bool[,] CeluleColorate)
        {

        }
    }
}
