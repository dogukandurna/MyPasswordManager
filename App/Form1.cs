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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exButton1_Click(object sender, EventArgs e)
        {
            string MainUsurname = "Hesap";
            string MainPassword = "12345";
            if (exTextBox1.Texts ==MainUsurname && exTextBox2.Texts ==MainPassword)
            {
                Form2 Management = new Form2();
                Management.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is wrong.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exTextBox1.ContextMenu = new ContextMenu();
            exTextBox2.ContextMenu = new ContextMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exTextBox1_Click(object sender, EventArgs e)
        {
            exTextBox1.Texts = "";
        }

        private void exTextBox1_Leave(object sender, EventArgs e)
        {
            if (exTextBox1.Texts == "")
            {
                exTextBox1.Texts = "Username";
            }
        }

        private void exTextBox2_Click(object sender, EventArgs e)
        {
            exTextBox2.Texts = "";
        }

        private void exTextBox2_Leave(object sender, EventArgs e)
        {
            if (exTextBox2.Texts == "")
            {
                exTextBox2.Texts = "Password";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
