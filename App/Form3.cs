using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.AccountsTableAdapter dt = new DataSet1TableAdapters.AccountsTableAdapter();

        private void exButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = (Form2)Application.OpenForms["Form2"];
            form2.BackForm2();
        }

        private void exButton2_Click(object sender, EventArgs e)
        {
            dt.AddAccount(exTextBox1.Texts, exTextBox2.Texts, exTextBox3.Texts, exTextBox4.Texts, exTextBox5.Texts);
            MessageBox.Show("The account is added to the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exButton3_Click(object sender, EventArgs e)
        {
            exTextBox1.Texts = "";
            exTextBox2.Texts = "";
            exTextBox3.Texts = "";
            exTextBox4.Texts = "";
            exTextBox5.Texts = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            exTextBox5.PasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exTextBox5.PasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
