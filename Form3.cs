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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Data.Data.generateReports();
            //Upload data automatically
            dataGridView1.DataSource = Data.Data.report_Condominia.OrderBy(x => x.Manteinance).ToArray();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.Data.report_Condominia.OrderBy(x => x.Manteinance).ToList();
        }

        private void buttonMost_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.Data.report_People.OrderBy(y => y.quantyProperties).ToList();
        }

        private void buttonHigger_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.Data.report_Condominia.OrderBy(x => x.Manteinance).ToList();
        }

        private void buttonLower_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.Data.report_Condominia.OrderBy(x => x.Manteinance).Reverse().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.Data.report_People.OrderBy(y => y.totalManteinance).ToList();
        }
    }
}
