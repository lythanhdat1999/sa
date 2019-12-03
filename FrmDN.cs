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
using Doancuoiky.Model;
namespace Doancuoiky.View
{
    public partial class FrmDN : Form
    {
        ConnectToSQL con = new ConnectToSQL();
        
        public FrmDN()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7UE09LRC;Initial Catalog=quanlybanhang;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtMa.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from Account where MaDN='" + tk + "'and MK='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    
                    FrmMain frmMain = new FrmMain();
                    frmMain.FormClosing += new FormClosingEventHandler(frm_FormClosing);
                    frmMain.Show();
                    this.Hide();
                    


                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
 
        }
        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
