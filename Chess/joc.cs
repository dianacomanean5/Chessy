using Chess.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class joc : Form
    {
        Tabla tabla;
        Piesa piesaSelectata;
        public joc()
        {
            InitializeComponent();
        }

        private void Joaca_Click(object sender, EventArgs e)
        {
            Jucator jucator = new Jucator();
            jucator.propriu = true;
            jucator.alb = true;
            VariabileGlobale.jucatori.Add(jucator);
            tabla=new Tabla();
            UmpleTabla();
        }

        private void UmpleTabla()
        {
            tabel.Rows.Clear();
            for (int j = 0; j < 7; j++)
            {

                int index = tabel.Rows.Add();
                for (int i = 0; i < 8; i++)
                {
                    Piesa piesa = Tabla.Table.board[i, j];
                    if (piesa != null)
                    {
                        tabel.Rows[index].Cells[i].Value = piesa.image;
                    }
                    else
                    {
                        tabel.Rows[index].Cells[i].Value = Properties.Resources.celulaGoala;
                    }
                }
            }
        }

        private void Sfarsit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Close();
        }

        private void joc_Load(object sender, EventArgs e)
        {
           
        }

        private void tabel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (piesaSelectata == null)
            {
                piesaSelectata = Tabla.Table.board[e.ColumnIndex, e.RowIndex];
                RegulaTipPiesa regulaMiscare = new RegulaTipPiesa(e.ColumnIndex, e.RowIndex);
                Tabla.Table.board[e.ColumnIndex, e.RowIndex] = null;
                UmpleTabla();
                tabel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gold;
                ColoreazaCelule(regulaMiscare.CeluleColorate);
            }
            else
            {
                if (tabel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Empty)
                {
                    Tabla.Table.board[e.ColumnIndex, e.RowIndex] = piesaSelectata;
                    piesaSelectata = null;
                    UmpleTabla();
                }
                else
                {
                    return;
                }
            }

            
        }

        private void ColoreazaCelule(bool[,] p)
        {
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (p[i,j])
                    {
                        tabel.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                    }
                }
            }
        }
    }

}
