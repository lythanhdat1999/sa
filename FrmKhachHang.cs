using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doancuoiky.Control;
using Doancuoiky.Object;
namespace Doancuoiky.View
{
    public partial class FrmKhachHang : Form
    {
        KhachHangCtrls khctr = new KhachHangCtrls();
        KhachHangObj khObj = new KhachHangObj();
        int flag = 0;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        public void bingding()
        {
            txtMKH.DataBindings.Clear();
            txtMKH.DataBindings.Add("Text", dgvKH.DataSource, "Makh");
            txtTKH.DataBindings.Clear();
            txtTKH.DataBindings.Add("Text", dgvKH.DataSource, "Tenkh");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("Text", dgvKH.DataSource, "Diachi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvKH.DataSource, "Sodt");
           

        }
        public void dis_en(bool e)
        {
            txtMKH.Enabled = e;
            txtTKH.Enabled = e;
            txtSDT.Enabled = e;
            txtDC.Enabled = e;
            
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }
        public void ganDuLieu(KhachHangObj khObj)
        {
            khObj.Makh = txtMKH.Text.Trim();
            khObj.Tenkh = txtTKH.Text.Trim();
            khObj.Diachi = txtDC.Text.Trim();
            khObj.Sodt = txtSDT.Text.Trim();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = khctr.getData();
            dgvKH.DataSource = dtKhachHang;
            bingding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            txtMKH.Text = "";
            txtTKH.Text = "";
            txtSDT.Text = "";
            txtDC.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khctr.delData(txtMKH.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtKhachHang = khctr.getData();
                    dgvKH.DataSource = dtKhachHang;
                    bingding();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(khObj);
            if (flag == 0)
            {

                if (khctr.addData(khObj))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtKhachHang= khctr.getData();
                    dgvKH.DataSource = dtKhachHang;
                    bingding();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (khctr.upData(khObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtKhachHang = khctr.getData();
                    dgvKH.DataSource = dtKhachHang;
                    bingding();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmKhachHang_Load(sender, e);
            dis_en(false);
        }

      
    }
}
