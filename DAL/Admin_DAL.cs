using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class Admin_DAL
    {
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public DataSet selectAdmin()
        {
            string sql = @"select * from Admin";
            return DBhelp.Create().ExecuteAdater(sql);
        }
        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int deleteAdmin(string username)
        {
            string sql = "delete from Admin where username=@username";
            SqlParameter[] sp ={
                                  new SqlParameter("@username",username)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int ExitAdmin(Admin a)
        {
            string sql = "update Admin set username=@username,password=@password where username=@username";
            SqlParameter[] sp = {
                                new SqlParameter("username",a.username),
                                new SqlParameter("password",a.password)
                                };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int AddAdmin(Admin a)
        {
            string sql = "insert into Admin select @username,@password";
            SqlParameter[] sp ={
                                new SqlParameter("username",a.username),
                                new SqlParameter("password",a.password)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        /// <summary>
        /// 查询相同用户
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int Scalar(Admin a)
        {
            string sql = "select COUNT(*) from Admin where username=@username and password=@password";
            SqlParameter[] sp ={
                                new SqlParameter("@username",a.username),
                                new SqlParameter("@password",a.password)
                              };
            return DBhelp.Create().ExecuteScalar(sql, sp);
        }
    }
}
