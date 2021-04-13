using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    public class Tabla
    {
        public Tabla()
        {
            pieseNegre = new List<Piesa>();
            pieseAlbe = new List<Piesa>();

            IncarcaObiectePiese();
            AdaugaPeTabla();
        }

        private void IncarcaObiectePiese()
        {
            
            for(int i=0;i<8;i++) 
            {
                Pion pionnegru = new Pion(false);
                pionnegru.x = i;
                pionnegru.y = 1;
                
                pieseNegre.Add(pionnegru);

                Pion pionalb = new Pion(true);
                pionalb.x = i;
                pionalb.y = 5;
                
                pieseAlbe.Add(pionalb);
            }

            Tura tura1negru = new Tura(false);
            tura1negru.x = 0;
            tura1negru.y = 0;
            pieseNegre.Add(tura1negru);

            Tura tura2negru = new Tura(false);
            tura2negru.x = 7;
            tura2negru.y = 0;
            pieseNegre.Add(tura2negru);

            Tura tura1alb = new Tura(true);
            tura1alb.x = 0;
            tura1alb.y = 6;
            pieseAlbe.Add(tura1alb);
            Tura tura2alb = new Tura(true);

            tura2alb.x = 7;
            tura2alb.y = 6;
            pieseAlbe.Add(tura2alb);

            Cal cal1alb = new Cal(true);
            cal1alb.x = 1;
            cal1alb.y = 6;
            pieseAlbe.Add(cal1alb);
            Cal cal2Alb = new Cal(true);
            cal2Alb.x = 6;
            cal2Alb.y = 6;
            pieseAlbe.Add(cal2Alb);

            Cal cal1negru=new Cal(false);
            cal1negru.x = 1;
            cal1negru.y = 0;
            pieseNegre.Add(cal1negru);
            Cal cal2negru = new Cal(false);
            cal2negru.x=6;
            cal2negru.y=0;
            pieseNegre.Add(cal2negru);

            Ofiter ofiter1alb = new Ofiter(true);
            ofiter1alb.x = 2;
            ofiter1alb.y = 6;
            pieseAlbe.Add(ofiter1alb);
            Ofiter ofiter2alb = new Ofiter(true);
            ofiter2alb.x = 5;
            ofiter2alb.y = 6;
            pieseAlbe.Add(ofiter2alb);
            Ofiter ofiter1negru = new Ofiter(false);
            ofiter1negru.x = 2;
            ofiter1negru.y = 0;
            pieseNegre.Add(ofiter1negru);
            Ofiter ofiter2negru = new Ofiter(false);
            ofiter2negru.x = 5;
            ofiter2negru.y = 0;
            pieseNegre.Add(ofiter2negru);

            Regina regina1alb = new Regina(true);
            regina1alb.x = 4;
            regina1alb.y = 6;
            pieseAlbe.Add(regina1alb);
            Regina regina1neagra = new Regina(false);
            regina1neagra.x = 4;
            regina1neagra.y = 0;
            pieseNegre.Add(regina1neagra);

            Rege rege1alb = new Rege(true);
            rege1alb.x = 3;
            rege1alb.y = 6;
            pieseAlbe.Add(rege1alb);
            Rege rege1negru = new Rege(false);
            rege1negru.x = 3;
            rege1negru.y = 0;
            pieseNegre.Add(rege1negru);



        }

        private void AdaugaPeTabla()
        {
            for(int i=0;i<pieseNegre.Count;i++)
            {
                board[pieseNegre[i].x, pieseNegre[i].y] = pieseNegre[i];
            }
            for (int i = 0; i < pieseAlbe.Count; i++)
            {
                board[pieseAlbe[i].x, pieseAlbe[i].y] = pieseAlbe[i];
            }
        }

        public Piesa[,] board = new Piesa[8, 7]; 
        public List<Piesa> pieseNegre;
        public List<Piesa> pieseAlbe;


    }
}
