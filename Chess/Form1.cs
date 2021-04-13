using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Istoric_Click(object sender, EventArgs e)
        {

            ISTORIC i = new ISTORIC();
            i.Show();
            this.Visible = false;



        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start s=new Start();
            s.Show();
            this.Visible=false;
        }

      
    }
}
