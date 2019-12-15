using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quanlybenhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void hồSơBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Hồ_sơ_bệnh_nhân frm0 = new Hồ_sơ_bệnh_nhân();
            frm0.MdiParent = this;
            frm0.Show();

           


        }

        private void hồSơBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hồ_sơ_Bệnh_án frm1 = new Hồ_sơ_Bệnh_án();
            frm1.MdiParent = this;
            frm1.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đĂNGKÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kHOANỘIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoanoi frmkhoanoi = new khoanoi();
            frmkhoanoi.MdiParent = this;
            frmkhoanoi.Show();
           

        }

        private void kHOANGOẠIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoangoai frmkhoangoai = new khoangoai();
            frmkhoangoai.MdiParent = this;
            frmkhoangoai.Show();
           
        }

        private void bácSỹToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bacsi frmbacsi = new bacsi();
            frmbacsi.MdiParent = this;
            frmbacsi.Show();
            

        }

    
        private void pHÒNGKHÁMTAIMŨIHỌNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmdannhap_Click(object sender, EventArgs e)
        {
           
           
        }

        private void đĂNGKÝToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đĂNGKÝToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien frmnhanvien = new nhanvien();
            frmnhanvien.MdiParent = this;
            frmnhanvien.Show();
           

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void phòngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phongkhambenh frmphongkham = new phongkhambenh();
            frmphongkham.MdiParent = this;
            frmphongkham.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đĂNGXUẤTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string message = "BẠN MUỐN ĐĂNG XUẤT KHỎI HỆ THỐNG!";
            string title = "ĐÓNG";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                dangnhap dn = new dangnhap();
                dn.ShowDialog();
            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tHÔNGTINDỰÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinduan frmthongtin = new thongtinduan();
            frmthongtin.MdiParent = this;
            frmthongtin.Show();
        }
    }
}
