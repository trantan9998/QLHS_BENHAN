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
    public partial class phongkhambenh : Form
    {
        public phongkhambenh()
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
                dataphongkhambenhbn.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        public void loadbacsi()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "select * from bacsi";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                databacsi.DataSource = tb;
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        public void loadphongkham()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "select * from dangkykhambenh";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                datadangkykhambenh.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadphongkham();
        }

        private void phongkhambenh_Load(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmakhambenh.Text !="" && txtmasobn.Text != ""&& txthovaten.Text!="" && cmbgioitinh.Text != "" && txtnamsinh.Text != "" && txtmasobs.Text !=""&& txthovatenbs.Text!="" && cbkhoa.Text!="")
                {
                    conn.Open();
                    string sql = "insert into dangkykhambenh values ('" + txtmakhambenh.Text + "','" + txtmasobn.Text + "','" + txthovaten.Text + "','" + cmbgioitinh.Text + "','" + txtnamsinh.Text +  "','" + txtmasobs.Text + "','" + txthovatenbs.Text + "','"+ cbkhoa.Text+ "')";
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

        private void bttcapnhapthongtin_Click(object sender, EventArgs e)
        {
            load();
            loadbacsi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataphongkhambenh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataphongkhambenhbn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasobn.Text = dataphongkhambenhbn.CurrentRow.Cells[0].Value.ToString();
            txthovaten.Text = dataphongkhambenhbn.CurrentRow.Cells[1].Value.ToString();
            cmbgioitinh.Text = dataphongkhambenhbn.CurrentRow.Cells[2].Value.ToString();
            txtnamsinh.Text = dataphongkhambenhbn.CurrentRow.Cells[4].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhambenh.Text = datadangkykhambenh.CurrentRow.Cells[0].Value.ToString();
            txtmasobn.Text = datadangkykhambenh.CurrentRow.Cells[1].Value.ToString();
            txthovaten.Text = datadangkykhambenh.CurrentRow.Cells[2].Value.ToString();
            cmbgioitinh.Text = datadangkykhambenh.CurrentRow.Cells[3].Value.ToString();
            txtnamsinh.Text = datadangkykhambenh.CurrentRow.Cells[4].Value.ToString();
            txtmasobs.Text = datadangkykhambenh.CurrentRow.Cells[5].Value.ToString();
            txthovatenbs.Text = datadangkykhambenh.CurrentRow.Cells[6].Value.ToString();
            cbkhoa.Text = datadangkykhambenh.CurrentRow.Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql = "delete from dangkykhambenh where id_phongkham='" + txtmakhambenh.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("xóa thành công");
                load();
                conn.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "update dangkykhambenh set id_benhnhan=N'" + txtmasobn.Text + "'," +
                    "hovatenbn=N'" + txthovaten.Text + "'," +
                    "gioitinhbn=N'" + cmbgioitinh.Text + "'," +
                    "namsinhbn=N'" + txtnamsinh.Text + "'," +
                    "id_bacsi=N'" + txtmasobs.Text + "'," +
                    "id_hovaten=N'" + txthovatenbs.Text + "'," +
                    "khoa=N'" + cbkhoa.Text + "' where id_phongkham='" + txtmakhambenh.Text + "'";
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

        private void txttuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filter = "cmnd='" + txttimkiem.Text + "'";
            CheckExist((DataTable)this.dataphongkhambenhbn.DataSource, filter);
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
            tbl = ((DataTable)this.dataphongkhambenhbn.DataSource).Clone();
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
                row[12] = rows[i].ItemArray[12].ToString();
                tbl.Rows.Add(row);
            }
            dataphongkhambenhbn.DataSource = tbl;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void databacsi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasobs.Text = databacsi.CurrentRow.Cells[0].Value.ToString();
            txthovatenbs.Text = databacsi.CurrentRow.Cells[1].Value.ToString();
            cbkhoa.Text = databacsi.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
