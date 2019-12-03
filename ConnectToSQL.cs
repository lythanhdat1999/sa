using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Doancuoiky.Model
{
    public class ConnectToSQL
    {
        private SqlConnection Conn;
        private SqlConnection _cmd;
        public SqlConnection CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        public SqlConnection Connection
        {
            get { return Conn; }
        }

        private string error;
        public string Error { get => error; set => error = value; }
        public string StrCon;
        public ConnectToSQL()
        {
            StrCon = @"Data Source=LAPTOP-7UE09LRC;Initial Catalog=quanlybanhang;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if(Conn.State==ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }


        
    }
}
