using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    class DBhelp
    {
        private DBhelp() { }
        private static DBhelp dbhelp = null;
        public static DBhelp Create()
        {
            if (dbhelp == null)
                dbhelp = new DBhelp();
            return dbhelp;
        }

        string conString = ConfigurationManager.ConnectionStrings["a"].ConnectionString;

        //返回一行一列
        public int ExecuteScalar(string sql, params SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddRange(sp);
                return (int)com.ExecuteScalar();
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
            finally
            {
                con.Close();
            }

        }

        //返回读取器对象
        public SqlDataReader ExecuteReader(string sql, params SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddRange(sp);
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }

        //返回数据集，
        public DataSet ExecuteAdater(string sql, params SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(conString);

            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddRange(sp);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "a");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }


        }

        //返回受影响行数
        public int ExecuteNonQuery(string sql, CommandType type = CommandType.Text, params SqlParameter[] sp)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddRange(sp);
                com.CommandType = type;
                return com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
