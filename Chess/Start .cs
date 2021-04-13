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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            joc n = new joc();
            n.Show();
            this.Visible = false;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          

        }
        }
    }

