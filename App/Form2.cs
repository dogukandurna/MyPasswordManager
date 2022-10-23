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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(10, 17, 40);
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainSaveButton_Click(object sender, EventArgs e)
        {
            LinkAccountsButton.Visible = false;
            MainSaveButton.Visible = false;
            Form3 Save = new Form3();
            Save.Name = "Test";
            if (Application.OpenForms["Test"] == null)
            {
                Save.MdiParent = this;
                Save.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(Save);
                Save.Show();
                Save.Location = new Point(10, 75);
            }
        }

        public void BackForm2()
        {
            MainSaveButton.Visible = true;
            LinkAccountsButton.Visible = true;
            exPanel1.Visible = true;
            pictureBox1.Visible = true;
        }

        private void LinkAccountsButton_Click(object sender, EventArgs e)
        {
            LinkAccountsButton.Visible = false;
            MainSaveButton.Visible = false;
            exPanel1.Visible = false;
            pictureBox1.Visible = false;
            Form4 List = new Form4();
            List.Name = "Test2";
            if (Application.OpenForms["Test2"] == null)
            {
                List.MdiParent = this;
                List.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(List);
                List.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
