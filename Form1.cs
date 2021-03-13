using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3_repaso
{
    public partial class Form1 : Form
    {
        private Form2 f2;
        private Form3 f3;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.StartPosition = FormStartPosition.CenterScreen;
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                f2.Activate();
            }
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f2.StartPosition = FormStartPosition.CenterScreen;
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                f3.Activate();
            }
        }
    }
}


