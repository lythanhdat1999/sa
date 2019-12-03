using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
using System.Data;
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
using Doancuoiky.Model;
using Doancuoiky.Object;
namespace Doancuoiky.Model
{
    public class HoaDonMod
    {
        SqlCommand cmd = new SqlCommand();
        ConnectToSQL con = new ConnectToSQL();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select hd.MaHD,hd.NgayLap,kh.TenKH from HoaDon hd,KhachHang kh where hd.MaKH=kh.MaKH";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public bool AddData(HoaDonObj hdObj)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Insert into HoaDon values('" + hdObj.Mahd + "',Convert(date,'" + hdObj.Ngaylap + "',103),'" + hdObj.Khachhang + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return false;

        }
        public bool UpData(HangHoaObj hhObj)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Update HangHoa set TenHang=N'" + hhObj.Tenhang + "',DonGia='" + hhObj.Dongia + "', XuatXu= N'" + hhObj.Xuatxu + "', SoLuong='" + hhObj.Soluong + "'where MaHH='" + hhObj.Mahh + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return false;

        }
        public bool DelData(string Mahh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete HangHoa where Mahh='" + Mahh + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return false;

        }
    }
}
