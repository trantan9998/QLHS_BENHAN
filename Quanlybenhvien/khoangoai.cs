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
namespace Quanlybenhvien
{
    public partial class khoangoai : Form
    {
        public khoangoai()
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
                string sql = "select * from dangkykhambenh";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                datakhambenh.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        public void loadkhambenh()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "select * from khoangoai";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                datakhoangoai.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void bttthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmakhoa.Text != ""  && txthovaten.Text != "" && txtmasobn.Text != "" && txtthucquan.Text != "" && txtungloettieuhoa.Text != "" && txtungthudaday.Text != "" && txtgan.Text != "" && txtlongnguc.Text != "" && txthomantinh.Text != "" && txtchandoan.Text != "" && txttoathuoc.Text != "" && txtmasobs.Text!="")
                {
                    conn.Open();
                    string sql = "insert into khoangoai values ( '" + txtmakhoa.Text  + "','" + txthovaten.Text + "','" + txtmasobn.Text + "','" + txtthucquan.Text + "','" + txtungloettieuhoa.Text + "','" + txtungthudaday.Text + "','" + txtgan.Text + "','" + txtlongnguc.Text + "','" + txthomantinh.Text + "','" + txtchandoan.Text + "','" + txttoathuoc.Text + "','" + txtmasobs.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("thêm thành công!");
                        load();
                    }

                    else

                        MessageBox.Show("thêm thất bại!");
                    conn.Close();
                }


                else
                    MessageBox.Show("chưa nhập đủ thông tin");

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadkhambenh();
        }

        private void khoangoai_Load(object sender, EventArgs e)
        {

        }

        private void databenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhambenh.Text = datakhambenh.CurrentRow.Cells[0].Value.ToString();
            txtmasobn.Text = datakhambenh.CurrentRow.Cells[1].Value.ToString();
            txthovaten.Text = datakhambenh.CurrentRow.Cells[2].Value.ToString();
            cmbgioitinh.Text = datakhambenh.CurrentRow.Cells[3].Value.ToString();
            txtnamsinh.Text = datakhambenh.CurrentRow.Cells[4].Value.ToString();
            txtmasobs.Text = datakhambenh.CurrentRow.Cells[5].Value.ToString();
            txthovatenbs.Text = datakhambenh.CurrentRow.Cells[6].Value.ToString();
            cbkhoa.Text = datakhambenh.CurrentRow.Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load();
        }

        private void datakhoangoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhoa.Text = datakhoangoai.CurrentRow.Cells[0].Value.ToString();
            txthovaten.Text = datakhoangoai.CurrentRow.Cells[1].Value.ToString();
            txtmasobn.Text = datakhoangoai.CurrentRow.Cells[2].Value.ToString();
            txtthucquan.Text = datakhoangoai.CurrentRow.Cells[3].Value.ToString();
            txtungloettieuhoa.Text = datakhoangoai.CurrentRow.Cells[4].Value.ToString();
            txtungthudaday.Text = datakhoangoai.CurrentRow.Cells[5].Value.ToString();     
            txtgan.Text = datakhoangoai.CurrentRow.Cells[6].Value.ToString();
            txtlongnguc.Text = datakhoangoai.CurrentRow.Cells[7].Value.ToString();
            txthomantinh.Text = datakhoangoai.CurrentRow.Cells[8].Value.ToString();
            txtchandoan.Text = datakhoangoai.CurrentRow.Cells[9].Value.ToString();
            txttoathuoc.Text = datakhoangoai.CurrentRow.Cells[10].Value.ToString();
            txtmasobs.Text = datakhoangoai.CurrentRow.Cells[11].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "update khoangoai set hovatenbn=N'" + txthovaten.Text + "'," +
                    "id_benhnhan=N'" + txtmasobn.Text + "'," +
                    "thucquan=N'" + txtthucquan.Text + "'," +
                    "ungloettieuhoa=N'" + txtungloettieuhoa.Text + "'," +
                    "ungthudaday=N'" + txtungthudaday.Text + "'," +               
                    "gan=N'" + txtgan.Text + "'," +
                    "benhlongnguc=N'" + txtlongnguc.Text + "'," +
                    "homantinh=N'" + txthomantinh.Text + "'," +
                    "chandoan=N'" + txtchandoan.Text + "'," +
                    "toathuoc=N'" + txttoathuoc.Text + "'," +
                    "id_bacsi=N'" + txtmasobs.Text + "' where id_khoangoai='" + txtmakhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {

                    MessageBox.Show("đã chỉnh sửa!");
                    load();
                }

                else

                    MessageBox.Show("sửa thất bại!");
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối:" + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filter = "hovatenbn='" + txttimkiem.Text + "'";
            CheckExist((DataTable)this.datakhambenh.DataSource, filter);
        }
        private void CheckExist(DataTable tbl, string filterExpression)
        {
            if (filterExpression == "")
            {
                return;
            }
            DataRow[] rows = tbl.Select(filterExpression);
            if (rows.Length <= 0)
            {
                return;
            }
            //Thể hiện dữ liệu tìm được ra databenhnhan
            tbl = ((DataTable)this.datakhambenh.DataSource).Clone();
            for (int i = 0; i < rows.Length; i++)
            {
                DataRow row = tbl.NewRow();
                row[0] = rows[i].ItemArray[0].ToString();
                row[1] = rows[i].ItemArray[1].ToString();
                row[2] = rows[i].ItemArray[2].ToString();
                row[3] = rows[i].ItemArray[3].ToString();
                row[4] = rows[i].ItemArray[4].ToString();
                row[5] = rows[i].ItemArray[5].ToString();
                row[6] = rows[i].ItemArray[6].ToString();
                row[7] = rows[i].ItemArray[7].ToString();           
                tbl.Rows.Add(row);
            }
            datakhambenh.DataSource = tbl;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtungthudaday_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtthucquan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtungloettieuhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtthucquan.Clear();
            txtungloettieuhoa.Clear();
            txtungthudaday.Clear();
            txtgan.Clear();
            txtlongnguc.Clear();
            txthomantinh.Clear();
            txtchandoan.Clear();
            txttoathuoc.Clear();

        }

        private void btloc_Click(object sender, EventArgs e)
        {
            string filter = "id_benhnhan='" + txttimkiemkhoanoi.Text + "'";
            Checkkhoangoai((DataTable)this.datakhoangoai.DataSource, filter);
        }
        private void Checkkhoangoai(DataTable tbl, string filterExpression)
        {
            if (filterExpression == "")
            {
                return;
            }
            DataRow[] rows = tbl.Select(filterExpression);
            if (rows.Length <= 0)
            {
                return;
            }
            //Thể hiện dữ liệu tìm được ra databenhnhan
            tbl = ((DataTable)this.datakhoangoai.DataSource).Clone();
            for (int i = 0; i < rows.Length; i++)
            {
                DataRow row = tbl.NewRow();
                row[0] = rows[i].ItemArray[0].ToString();
                row[1] = rows[i].ItemArray[1].ToString();
                row[2] = rows[i].ItemArray[2].ToString();
                row[3] = rows[i].ItemArray[3].ToString();
                row[4] = rows[i].ItemArray[4].ToString();
                row[5] = rows[i].ItemArray[5].ToString();
                row[6] = rows[i].ItemArray[6].ToString();
                row[7] = rows[i].ItemArray[7].ToString();
                row[8] = rows[i].ItemArray[8].ToString();
                row[9] = rows[i].ItemArray[9].ToString();
                row[10] = rows[i].ItemArray[10].ToString();
                row[11] = rows[i].ItemArray[11].ToString();
                tbl.Rows.Add(row);
            }
            datakhoangoai.DataSource = tbl;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Xetnghiem xetnghiem = new Xetnghiem();
            xetnghiem.ShowDialog();
        }
    }
}
