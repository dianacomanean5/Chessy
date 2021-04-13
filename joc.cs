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
        Miscare miscare;
        public joc()
        {
            InitializeComponent();
        }
        Client client;
        private void Joaca_Click(object sender, EventArgs e)
        {
            Jucator jucator = new Jucator();
            jucator.propriu = true;
            jucator.alb = true;
            VariabileGlobale.jucatori.Add(jucator);
            tabla=new Tabla();
            client = new Client();
            UmpleTabla();
            
        }

        private void UmpleTabla()
        {
            if(client.miscare!=null)
            {
                tabla.board[client.miscare.Coloana, client.miscare.Rand] = tabla.board[client.miscare.ColoanaInitiala, client.miscare.RandInitial];
                tabla.board[client.miscare.ColoanaInitiala, client.miscare.RandInitial] = null;
                client.miscare = null;
            }
            tabel.Rows.Clear();
            for (int j = 0; j < 7; j++)
            {

                int index = tabel.Rows.Add();
                for (int i = 0; i < 8; i++)
                {
                    Piesa piesa = tabla.board[i, j];
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
            try
            {
                if (piesaSelectata == null)
                {
                    miscare = new Miscare();
                    miscare.ColoanaInitiala = e.ColumnIndex;
                    miscare.RandInitial = e.RowIndex;

                    piesaSelectata = tabla.board[e.ColumnIndex, e.RowIndex];
                    RegulaTipPiesa regulaMiscare = new RegulaTipPiesa(e.ColumnIndex, e.RowIndex, tabla);
                    tabla.board[e.ColumnIndex, e.RowIndex] = null;
                    UmpleTabla();
                    tabel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gold;
                    ColoreazaCelule(regulaMiscare.CeluleColorate);
                }
                else
                {
                    if (tabel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Empty)
                    {
                        tabla.board[e.ColumnIndex, e.RowIndex] = piesaSelectata;
                        piesaSelectata = null;
                        if (tabel.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Gold)
                        {
                            miscare.Coloana = e.ColumnIndex;
                            miscare.Rand = e.RowIndex;
                            client.SendMessage(miscare);
                            client.ReceiveMessage();
                        }
                        UmpleTabla();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch { }

            
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

        private void tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
