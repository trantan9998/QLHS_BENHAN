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
    public partial class nhanvien : Form
    {
        public nhanvien()
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
                string sql = "select * from nhanvien";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                datanhanvien.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        /*
        public bool kiemtranhanvien(int manhanvien)
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();
            string sql = "select id_nhanvien from nhanvien where id_nhanvien='" + manhanvien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        */
      
        private void datahosobenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            load();
        }

        private void bttLƯU_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmanhanvien.Text != "" && txthovatennv.Text != "" && cbgioitinhnv.Text != "" && txtdiachinv.Text != "" && txtnamsinh.Text != "" && txtnoisinhnv.Text != "" && txtcmndnv.Text != "" && txtsdtnv.Text != "" && txttrinhdohocvannv.Text != "" && txtemailnv.Text != "" && txttentaikhoan.Text != "" && txtmatkhau.Text != "")
                {
                    conn.Open();
                    string sql = "insert into nhanvien values ('" + txtmanhanvien.Text + "','" + txthovatennv.Text + "','" + cbgioitinhnv.Text + "','" + txtdiachinv.Text + "','" + txtnamsinh.Text + "','" + txtnoisinhnv.Text + "','" + txtcmndnv.Text + "','" + txtsdtnv.Text + "','" + txttrinhdohocvannv.Text + "','" + txtemailnv.Text + "','" + txttentaikhoan.Text + "','" + txtmatkhau.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq =cmd.ExecuteNonQuery();
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


        private void bttthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql = "delete from nhanvien where id_nhanvien='" +txtmanhanvien.Text +"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("xóa thành công");
                load();
                conn.Close();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nhanvien_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHOSO_BENHVIENDataSet.nhanvien' table. You can move, or remove it, as needed.


        }

        private void datanhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Clear();
            txthovatennv.Clear();
            txtdiachinv.Clear();
            txtnoisinhnv.Clear();
            txtcmndnv.Clear();
            txtsdtnv.Clear();
          
            txtnamsinh.Clear();
            txttrinhdohocvannv.Clear();
            txtemailnv.Clear();
            txttentaikhoan.Clear();
            txtmatkhau.Clear();

        }

        private void txtdiachinv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhanvienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void datanhanvien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "update nhanvien set hovaten=N'"+txthovatennv.Text+"'," +
                    "gioitinh=N'"+cbgioitinhnv.Text+"'," +
                    "diachi=N'"+txtdiachinv.Text+"'," +
                    "namsinh=N'"+txtnamsinh.Text+"'," +
                    "noisinh=N'"+txtnoisinhnv.Text+"'," +
                    "cmnd=N'"+txtcmndnv.Text+"'," +
                    "sdt=N'"+txtsdtnv.Text+"'," +
                    "trinhdohocvan=N'"+txttrinhdohocvannv.Text+"'," +
                    "email=N'"+txtemailnv.Text+"'," +
                    "tentaikhoan=N'"+txttentaikhoan.Text+"'," +
                    "matkhau=N'"+txtmatkhau.Text+"' where id_nhanvien='" + txtmanhanvien.Text + "'";
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

        private void datanhanvien_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            txtmanhanvien.Text = datanhanvien.CurrentRow.Cells[0].Value.ToString();
            txthovatennv.Text = datanhanvien.CurrentRow.Cells[1].Value.ToString();
            cbgioitinhnv.Text = datanhanvien.CurrentRow.Cells[2].Value.ToString();
            txtdiachinv.Text = datanhanvien.CurrentRow.Cells[3].Value.ToString();
            txtnamsinh.Text = datanhanvien.CurrentRow.Cells[4].Value.ToString();
            txtnoisinhnv.Text = datanhanvien.CurrentRow.Cells[5].Value.ToString();
            txtcmndnv.Text = datanhanvien.CurrentRow.Cells[6].Value.ToString();
            txtsdtnv.Text = datanhanvien.CurrentRow.Cells[7].Value.ToString();
            txttrinhdohocvannv.Text = datanhanvien.CurrentRow.Cells[8].Value.ToString();
            txtemailnv.Text = datanhanvien.CurrentRow.Cells[9].Value.ToString();
            txttentaikhoan.Text = datanhanvien.CurrentRow.Cells[10].Value.ToString();
            txtmatkhau.Text = datanhanvien.CurrentRow.Cells[11].Value.ToString();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
