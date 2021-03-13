using Lab3_repaso.Data;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textDPI.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool validateFieldstoPerson()
        {
            //Validate people's textFields
            return !textDPI.Text.Equals("") &&
                !textName.Text.Equals("") &&
                !textLast.Text.Equals("");
        }

        private bool validateFilestoPropertys()
        {
            //Validate the textFields and the comboBox of the condominiums
            return !comboBox1.Text.Equals("") &&
                !textNumber.Text.Equals("") &&
                !textMantainance.Text.Equals("");
        }

        private void clearTextFiles()
        {
            textDPI.Text = "";
            textName.Text = "";
            textLast.Text = "";
            comboBox1.SelectedIndex = 0;
            textNumber.Text = "";
            textMantainance.Text = "";
        }
        private void buttonPerson_Click(object sender, EventArgs e)
        {
            if( validateFieldstoPerson())
            {
                Data.Data.personals.Add(
                    new Classs.Personal_data(
                        textDPI.Text,
                        textName.Text,
                        textLast.Text));
                Data.Data.savePerson();
                Data.Data.generateReports();
                comboBox1.Items.Add(textDPI.Text);
                clearTextFiles();
            }
        }

        private void buttonProperty_Click(object sender, EventArgs e)
        {
            if( validateFilestoPropertys() )
            {
                Data.Data.condominia.Add(
                    new Classs.Condominium_data(
                        comboBox1.Text,
                        int.Parse(textNumber.Text),
                        double.Parse(textMantainance.Text)));
                Data.Data.saveCondominium();
                Data.Data.generateReports();
                clearTextFiles();
            }
        }
    }
}
