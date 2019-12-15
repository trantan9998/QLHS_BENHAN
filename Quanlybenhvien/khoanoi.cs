﻿using System;
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
    public partial class khoanoi : Form
    {
        public khoanoi()
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
                string sql = "select * from khoanoi";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                datakhoanoi.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }

       
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void khoanoi_Load(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                if (txtmakhoa.Text!=""&& txthovaten.Text != "" && txtmasobn.Text != "" && txtbenhlaynhiem.Text != "" && txtnoithan.Text != "" && txtda.Text != "" && txtnoitimmach.Text != "" && txthohap.Text != "" && txttieuhoa.Text != "" && txtchandoan.Text != "" && txttoathuoc.Text != "" && txtmasobs.Text != "") 
                {
                    conn.Open();
                    string sql = "insert into khoanoi values ( '"+ txtmakhoa.Text +"','" + txthovaten.Text + "','" + txtmasobn.Text + "','" + txtbenhlaynhiem.Text + "','" + txtnoithan.Text + "','" + txtda.Text + "','" + txtnoitimmach.Text + "','" + txthohap.Text + "','" + txttieuhoa.Text + "','" + txtchandoan.Text + "','" + txttoathuoc.Text + "','"  + txtmasobs.Text + "')";
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
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadkhambenh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql = "delete from khoanoi where id_khoanoi='" + txtmakhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("xóa thành công");
                load();
                conn.Close();
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void datakhoanoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhoa.Text = datakhoanoi.CurrentRow.Cells[0].Value.ToString();
            txthovaten.Text = datakhoanoi.CurrentRow.Cells[1].Value.ToString();
            txtmasobs.Text = datakhoanoi.CurrentRow.Cells[2].Value.ToString();
            txtbenhlaynhiem.Text = datakhoanoi.CurrentRow.Cells[3].Value.ToString();
            txtnoithan.Text = datakhoanoi.CurrentRow.Cells[4].Value.ToString();
            txtda.Text = datakhoanoi.CurrentRow.Cells[5].Value.ToString();
            txtnoitimmach.Text = datakhoanoi.CurrentRow.Cells[6].Value.ToString();
            txthohap.Text = datakhoanoi.CurrentRow.Cells[7].Value.ToString();
            txttieuhoa.Text = datakhoanoi.CurrentRow.Cells[8].Value.ToString();
            txtchandoan.Text = datakhoanoi.CurrentRow.Cells[9].Value.ToString();
            txttoathuoc.Text = datakhoanoi.CurrentRow.Cells[10].Value.ToString();
            txtmasobs.Text = datakhoanoi.CurrentRow.Cells[11].Value.ToString();
           

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();
                string sql = "update khoanoi set hovatenbn=N'" + txthovaten.Text + "'," +
                    "id_benhnhan=N'" + txtmasobn.Text + "'," +
                    "benhlaynhiem=N'" + txtbenhlaynhiem.Text + "'," +
                    "noithan=N'" + txtnoithan.Text + "'," +
                    "da=N'" + txtda.Text + "'," +
                    "timmach=N'" + txtnoitimmach.Text + "'," +
                    "hohap=N'" + txthohap.Text + "'," +
                    "tieuhoa=N'" + txttieuhoa.Text + "'," +
                    "chandoan=N'" + txtchandoan.Text + "'," +
                    "toathuoc=N'" + txttoathuoc.Text + "'," +
                    "id_bacsi=N'" + txtmasobs.Text + "' where id_khoanoi='" + txtmakhoa.Text + "'";
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
            string filter = "id_benhnhan='" + txttimkiem.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Xetnghiem xetnghiem = new Xetnghiem();
            xetnghiem.ShowDialog();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbenhlaynhiem.Clear();
            txtnoithan.Clear();
            txtda.Clear();
            txtnoitimmach.Clear();
            txthohap.Clear();
            txttieuhoa.Clear();
            txtchandoan.Clear();
            txttoathuoc.Clear();
        }

        private void txthovatenbs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btloc_Click(object sender, EventArgs e)
        {
            string filter = "id_benhnhan='" + txttimkiemkhoanoi.Text + "'";
            Checkkhoanoi((DataTable)this.datakhoanoi.DataSource, filter);
        }
        private void Checkkhoanoi(DataTable tbl, string filterExpression)
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
            tbl = ((DataTable)this.datakhoanoi.DataSource).Clone();
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
            datakhoanoi.DataSource = tbl;
        }

        private void txttimkiemkhoanoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
