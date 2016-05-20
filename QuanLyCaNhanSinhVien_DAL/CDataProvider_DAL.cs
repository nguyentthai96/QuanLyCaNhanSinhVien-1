using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CDataProvider_DAL
    {
        SqlConnection conn;
        SqlDataAdapter adp;
        SqlCommand cmd;
        string strConn = "Data Source=(local);Initial Catalog=QuanLyCaNhanSinhVien;Integrated Security=True";

        public CDataProvider_DAL()
        {
            conn = new SqlConnection(strConn);
            connectDataBase();
            cmd = conn.CreateCommand();
            cmd.Parameters.Clear();
        }

        public SqlConnection connectDataBase()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            return conn;
        }

        public void DisconnectDataBase()
        {
            if (conn.State==ConnectionState.Open)
                conn.Close();
        }

        public DataTable getDataTableExcuteQuery(string strNameTable, string strSelectCommand)
        {
            adp = new SqlDataAdapter(strSelectCommand, conn);
            DataTable dtb = new DataTable(strNameTable);
            try
            {
                adp.Fill(dtb);
            }
            catch(Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
            return dtb;
        }

        public bool excuteNonQuery(string strSqlCommand, ref string error, params SqlParameter[] param)
        {
            conn = this.connectDataBase();
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);         
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSqlCommand;
            bool flag = false;
            try
            {
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                DisconnectDataBase();
            }
            return flag;
        }
        public bool excuteNonQuery(string strSqlCommand, CommandType cmdType, ref string error, params SqlParameter[] param)
        {
            conn = this.connectDataBase();
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            cmd.CommandType = cmdType;
            cmd.CommandText = strSqlCommand;
            bool flag = false;
            try
            {
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                DisconnectDataBase();
            }
            return flag;
        }
        public int executeScalar(CommandType cmdType, string strSqlCommandText, ref string error, params SqlParameter[] param)
        {
            conn = this.connectDataBase();
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);

            cmd.CommandType = cmdType;
            cmd.CommandText = strSqlCommandText;

            int resutl =-1;
            try
            {
                resutl = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                DisconnectDataBase();
            }
            return resutl;
        }
    }
}
