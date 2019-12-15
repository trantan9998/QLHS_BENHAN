using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace Quanlybenhvien
{
   
    public partial class Hồ_sơ_Bệnh_án : Form
    {
      
        public Hồ_sơ_Bệnh_án()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=VANTAN\TRANTAN;Initial Catalog=QLHOSO_BENHVIEN;Integrated Security=True";
        SqlConnection conn = null;
        public void load()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "select * from hosobenhnhan";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                databenhan.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hồ_sơ_Bệnh_án_Load(object sender, EventArgs e)
        {
            
        }

        private void databenhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btthem_Click(object sender, EventArgs e)
        {
         

        }

        private void Hồ_sơ_Bệnh_án_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasobn.Text = databenhan.CurrentRow.Cells[0].Value.ToString();
            txthovatenbn.Text = databenhan.CurrentRow.Cells[1].Value.ToString();
            cbgioitinhbn.Text = databenhan.CurrentRow.Cells[2].Value.ToString();
            txtdiachibn.Text = databenhan.CurrentRow.Cells[3].Value.ToString();
            txtnoisinhbn.Text = databenhan.CurrentRow.Cells[4].Value.ToString();
            txtcmndbn.Text = databenhan.CurrentRow.Cells[5].Value.ToString();
            txtsodtbn.Text = databenhan.CurrentRow.Cells[6].Value.ToString();
            txtnamsinh.Text = databenhan.CurrentRow.Cells[7].Value.ToString();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void bttcapnhapdanhsach_Click(object sender, EventArgs e)
        {
            load();
      
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string message = "BẠN CÓ MUỐN TRUY XUẤT DỮ LIỆU KHÔNG?";
            string title = "ĐÓNG";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                excel(databenhan, @"D:\BAO CAO DO AN\BAO CAO DO AN\FORM_QLBV_KHOA CAP CUU\truyxuatdulieu\", "DATA_Hồ sơ bệnh nhân");
            }
            else
            {

            }
        }
        private void excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

    }
}
