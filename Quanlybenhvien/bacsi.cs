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
    public partial class bacsi : Form
    {
        public bacsi()
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bacsi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHOSO_BENHVIENDataSet.bacsi' table. You can move, or remove it, as needed.

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            load();
        }

        private void databacsi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void databacsi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmasobs.Text = databacsi.CurrentRow.Cells[0].Value.ToString();
            txthovatenbs.Text = databacsi.CurrentRow.Cells[1].Value.ToString();
            txtnamsinhbs.Text = databacsi.CurrentRow.Cells[2].Value.ToString();
            txtchuyenmonbs.Text = databacsi.CurrentRow.Cells[3].Value.ToString();
            txtkinhnghiembs.Text = databacsi.CurrentRow.Cells[4].Value.ToString();
            cbkhoa.Text = databacsi.CurrentRow.Cells[5].Value.ToString();
            txttrinhdo.Text = databacsi.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
