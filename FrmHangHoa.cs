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
using Doancuoiky.Control;
using Doancuoiky.Object;
namespace Doancuoiky.View
{   
    public partial class FrmHangHoa : Form
    {
        HangHoaCtrls hhctr = new HangHoaCtrls();
        HangHoaObj hhObj = new HangHoaObj();
        int flag = 0;
        public FrmHangHoa()
        {
            InitializeComponent();
        }

        
        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHangHoa = hhctr.getData();
            dgvHangHoa.DataSource = dtHangHoa;
          
            bingding();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text",dgvHangHoa.DataSource,"MaHH");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvHangHoa.DataSource, "TenHang");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvHangHoa.DataSource, "DonGia");
            txtXuatxu.DataBindings.Clear();
            txtXuatxu.DataBindings.Add("Text", dgvHangHoa.DataSource, "XuatXu");
            txtSoluong.DataBindings.Clear();
            txtSoluong.DataBindings.Add("Text", dgvHangHoa.DataSource, "SoLuong");
          
        }
        public void dis_en(bool e)
        {
            txtMa.Enabled = e;
            txtTen.Enabled = e;
            txtGia.Enabled = e;
            txtXuatxu.Enabled = e;
            txtSoluong.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            txtMa.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            txtXuatxu.Text = "";
            txtSoluong.Text = "";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);

        }

        public void ganDuLieu(HangHoaObj hhObj)
        {
            hhObj.Mahh = txtMa.Text.Trim();
            hhObj.Tenhang = txtTen.Text.Trim();
            hhObj.Dongia = int.Parse(txtGia.Text.Trim());
            hhObj.Xuatxu = txtXuatxu.Text.Trim();
            hhObj.Soluong = int.Parse(txtSoluong.Text.Trim());
          

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhctr.delData(txtMa.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtHangHoa = hhctr.getData();
                    dgvHangHoa.DataSource = dtHangHoa;
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
            ganDuLieu(hhObj);
            if (flag == 0)
            {
                if (hhctr.addData(hhObj))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtHangHoa = hhctr.getData();
                    dgvHangHoa.DataSource = dtHangHoa;
                    bingding();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (hhctr.upData(hhObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtHangHoa = hhctr.getData();
                    dgvHangHoa.DataSource = dtHangHoa;
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
            FrmHangHoa_Load(sender, e);
            dis_en(false);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

       
    }
}
