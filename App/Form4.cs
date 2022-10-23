using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // SQL BAĞLANTILARI
        SqlConnection con = new SqlConnection("Data Source=DGKN\\SQLEXPRESS;Initial Catalog=MPM;Integrated Security=True");
        DataSet1TableAdapters.AccountsTableAdapter dt = new DataSet1TableAdapters.AccountsTableAdapter();
        DataTable table1 = new DataTable();

        private void exButton1_Click(object sender, EventArgs e)
        {
            // Back tuşuna basılınca form4ü kapatıp form2 ye dönüyor.
            this.Close();
            Form2 form2 = (Form2)Application.OpenForms["Form2"];
            form2.BackForm2();
        }

        private void exButton2_Click(object sender, EventArgs e)
        {
            // Tabloyu refreshliyor.
            dataGridView1.DataSource = dt.AccountsList();
        }

        private void exButton3_Click(object sender, EventArgs e)
        {
            // Tıklanan satırın verilerini tablodan siliyor.
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                con.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Accounts where ID ='" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Records have been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void exButton4_Click(object sender, EventArgs e)
        {
            // Textboxta veri değişikliği yapılıp tıklanınca verileri tablo da değiştiriyor.
            
            dt.UpdateList(exTextBox1.Texts, exTextBox2.Texts, exTextBox3.Texts, exTextBox4.Texts, exTextBox5.Texts, Convert.ToInt32(textBox6.Text));
            dataGridView1.DataSource = dt.AccountsList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Password sütununu yıldız olarak gösteriyor.
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Accounts' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.accountsTableAdapter.FillAccounts(this.dataSet1.Accounts);
            // textbox sağ tık kapatıyor
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.Columns[4].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.Columns[5].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void exTextBox7__TextChanged(object sender, EventArgs e)
        {
            // FİLTRELİ ARAMA
            table1.Clear();
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * FROM Accounts where ID like '%" + exTextBox7.Texts + "%' or SiteorAppName like '%" + exTextBox7.Texts + "%' or URL like '%" + exTextBox7.Texts + "%' or Email like '%" + exTextBox7.Texts + "%' or Usurname like '%" + exTextBox7.Texts + "%' or Password like '%" + exTextBox7.Texts + "%' ", con);
            adtr.Fill(table1);
            dataGridView1.DataSource = table1;
            con.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Bir satıra tıklandığında verileri textboxta gösteriyorlar.
            exTextBox1.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            exTextBox2.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            exTextBox3.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            exTextBox4.Texts = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            exTextBox5.Texts = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void exToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (exToggleButton1.Checked)
            {
                exTextBox5.PasswordChar = false;
            }
            else
            {
                exTextBox5.PasswordChar = true;
            }
        }

        private void exTextBox7_Click(object sender, EventArgs e)
        {
            exTextBox7.Texts = "";
        }

        private void exTextBox7_Leave(object sender, EventArgs e)
        {
            if (exTextBox7.Texts == "")
            {
                exTextBox7.Texts = "Search";
                // Tabloyu refreshliyor.
                dataGridView1.DataSource = dt.AccountsList();
            }
        }
    }
}
