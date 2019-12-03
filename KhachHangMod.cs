using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Doancuoiky.Model;
using Doancuoiky.Object;
namespace Doancuoiky.Model
{
    class KhachHangMod
    {
        SqlCommand cmd = new SqlCommand();
        ConnectToSQL con = new ConnectToSQL();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from KhachHang";
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
        public bool AddData(KhachHangObj khObj)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Insert into KhachHang values('" + khObj.Makh + "',N'" + khObj.Tenkh + "',N'" + khObj.Diachi + "','" + khObj.Sodt+ "')";
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
        public bool UpData(KhachHangObj khObj)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Update KhachHang set TenKH= N'" + khObj.Tenkh + "', DiaChi= N'" + khObj.Diachi + "', SoDT='" + khObj.Sodt + "'where MaKH='" + khObj.Makh + "'";
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
        public bool DelData(string Makh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete KhachHang where MaKH='" + Makh + "'";
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
