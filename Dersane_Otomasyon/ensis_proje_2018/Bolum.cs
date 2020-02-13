using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ensis_proje_2018
{
    public partial class Frm_Bolum : Form
    {
        public Frm_Bolum()
        {
            InitializeComponent();
        }

        public DataTable tablo = new DataTable();
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ensis_proje_2018.accdb");
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand kmt = new OleDbCommand();
        void listele()
        {

            txt_bolum.Text = "";
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select bolum_no,bolum_adi From bolumler", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
        }

        private void Frm_Bolum_Load(object sender, EventArgs e)
        {
            listele();       
           
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "INSERT INTO bolumler(bolum_adi) VALUES ('" + txt_bolum.Text + "')";
            kmt.ExecuteNonQuery();
            bag.Close();
            listele();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
        
            bag.Open();
            int id = 0;
            if (!string.IsNullOrEmpty(lblid.Text))
            {
                id = Convert.ToInt32(lblid.Text);
            }
            else
            {
                id = 0;
            }
            kmt.Connection = bag;
            kmt.CommandText = "DELETE from bolumler WHERE bolum_no=" + id+ "";
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            bag.Close();
            listele();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int idi = 0;
            if (!string.IsNullOrEmpty(lblid.Text))
            {
                idi = Convert.ToInt32(lblid.Text);
            }
            else
            {
                idi = 0;
            }
             string sorgu = "UPDATE bolumler SET bolum_adi='" + txt_bolum.Text + "'where  bolum_no= " + idi + "";
            OleDbCommand kmt = new OleDbCommand(sorgu, bag);
            bag.Open();
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            bag.Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_bolum.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_bolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            listele();
           
        }

        private void btn_excell_Click(object sender, EventArgs e)
        {
            
            Microsoft.Office.Interop.Excel._Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myrange.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j+2, i + 1];
                    myrange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
        

        }
    }

