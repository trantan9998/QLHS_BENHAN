using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Quanlybenhvien
{
    public partial class Hồ_sơ_bệnh_nhân : Form
    {
        public Hồ_sơ_bệnh_nhân()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=VANTAN\TRANTAN;Initial Catalog=QLHOSO_BENHVIEN;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataReader adapt;
        DataTable dt;
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
                databenhnhan.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        private void hienthi()
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmasobn.Text != "" && txthovatenbn.Text != "" && cbgioitinhbn.Text != "" && txtdiachibn.Text != "" && txtnamsinh.Text != "" && txtnoisinhbn.Text != "" && txtcmndbn.Text != "" && txtsodtbn.Text != "" && txtdantocbn.Text != "" && txtnghenghiepbn.Text != "" && cbnhommaubn.Text != "" && txtchieucaobn.Text != "" && txtcannangbn.Text != "")
                {
                    conn.Open();
                    string sql = "insert into hosobenhnhan values ('" + txtmasobn.Text + "','" + txthovatenbn.Text + "','" + cbgioitinhbn.Text + "','" + txtdiachibn.Text + "','" + txtnamsinh.Text + "','" + txtnoisinhbn.Text + "','" + txtcmndbn.Text + "','" + txtsodtbn.Text + "','" + txtdantocbn.Text + "','" + txtnghenghiepbn.Text + "','" + cbnhommaubn.Text + "','" + txtchieucaobn.Text + "','"+txtcannangbn.Text+"')";
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
        private void lsthosobenhnhan_SelectedIndexChanged(object sender, EventArgs e)
        {
           }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datahosobenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Hồ_sơ_bệnh_nhân_Load(object sender, EventArgs e)
        {
            
            
         }

        private void button5_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql = "delete from hosobenhnhan where id_benhnhan='" + txtmasobn.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("xóa thành công");
                load();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "update hosobenhnhan set hovaten=N'" + txthovatenbn.Text + "'," +
                    "gioitinh=N'" + cbgioitinhbn.Text + "'," +
                    "diachi=N'" + txtdiachibn.Text + "'," +
                    "namsinh=N'" + txtnamsinh.Text + "'," +
                    "noisinh=N'" + txtnoisinhbn.Text + "'," +
                    "cmnd=N'" + txtcmndbn.Text + "'," +
                    "sdt=N'" + txtsodtbn.Text + "'," +
                    "dantoc=N'" + txtdantocbn.Text + "'," +
                    "nghenghiep=N'" + txtnghenghiepbn.Text + "'," +
                    "nhommau=N'" + cbnhommaubn.Text + "'," +
                    "chieucao=N'" + txtchieucaobn.Text + "' where id_benhnhan='" + txtmasobn.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {

                    MessageBox.Show("BẠN CHẮC CHẮN SỬA NỘI DUNG !");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtmasobn.Clear();
            txthovatenbn.Clear();
            txtdiachibn.Clear();
            txtnamsinh.Clear();
            txtnoisinhbn.Clear();
            txtcmndbn.Clear();
            txtsodtbn.Clear();
            txtdantocbn.Clear();
            txtnghenghiepbn.Clear();
            txtchieucaobn.Clear();
            txtcannangbn.Clear();

        }

        private void databenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasobn.Text = databenhnhan.CurrentRow.Cells[0].Value.ToString();
            txthovatenbn.Text = databenhnhan.CurrentRow.Cells[1].Value.ToString();
            cbgioitinhbn.Text = databenhnhan.CurrentRow.Cells[2].Value.ToString();
            txtdiachibn.Text = databenhnhan.CurrentRow.Cells[3].Value.ToString();
            txtnamsinh.Text = databenhnhan.CurrentRow.Cells[4].Value.ToString();
            txtnoisinhbn.Text = databenhnhan.CurrentRow.Cells[5].Value.ToString();
            txtcmndbn.Text = databenhnhan.CurrentRow.Cells[6].Value.ToString();
            txtsodtbn.Text = databenhnhan.CurrentRow.Cells[7].Value.ToString();
            txtdantocbn.Text = databenhnhan.CurrentRow.Cells[8].Value.ToString();
            txtnghenghiepbn.Text = databenhnhan.CurrentRow.Cells[9].Value.ToString();
            cbnhommaubn.Text = databenhnhan.CurrentRow.Cells[10].Value.ToString();
            txtchieucaobn.Text = databenhnhan.CurrentRow.Cells[11].Value.ToString();
            txtcannangbn.Text = databenhnhan.CurrentRow.Cells[12].Value.ToString();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string filter = "cmnd='" + txttimkiem.Text + "'";
            CheckExist((DataTable)this.databenhnhan.DataSource, filter);

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
            tbl = ((DataTable)this.databenhnhan.DataSource).Clone();
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
            databenhnhan.DataSource = tbl;
        }

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtdiachibn_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
