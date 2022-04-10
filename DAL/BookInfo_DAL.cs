using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BookInfo_DAL
    {
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public SqlDataReader selectBookInfo()
        {
            string sql = @"select * from BookInfo";
            return DBhelp.Create().ExecuteReader(sql);
        }

        public int deleteBookInfo(string ID)
        {
            string sql = "delete from BookInfo where ID=@ID";
            SqlParameter[] sp ={
                                  new SqlParameter("@ID",ID)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        public int updateBookInfo(BookInfo info)
        {
            string sql = "update BookInfo set name=@name,count=@count,category1=@category1,category2=@category2,category3=@category3,addr=@addr where ID=@ID";
            SqlParameter[] sp = {
                                new SqlParameter("ID",info.ID),
                                new SqlParameter("name",info.name),
                                new SqlParameter("count",info.count),
                                new SqlParameter("category1",info.category1),
                                new SqlParameter("category2",info.category2),
                                new SqlParameter("category3",info.category3),
                                new SqlParameter("addr",info.addr)
                                };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        public int AddBookInfo(BookInfo info)
        {
            string sql = "insert into BookInfo (name,count,category1,category2,category3,addr) values( @name,@count,@category1,@category2,@category3,@addr )";
            SqlParameter[] sp = {
                                new SqlParameter("name",info.name),
                                new SqlParameter("count",info.count),
                                new SqlParameter("category1",info.category1),
                                new SqlParameter("category2",info.category2),
                                new SqlParameter("category3",info.category3),
                                new SqlParameter("addr",info.addr)
                                };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        public SqlDataReader query(BookInfo info)
        {
            string sql = @"select * from BookInfo where name like '%'+@name+'%' and ID = @ID and category1 = @category1 and category2 = @category2 and category3 = @category3";
            SqlParameter[] sp = {
                                new SqlParameter("name",info.name),
                                new SqlParameter("ID",info.ID),
                                new SqlParameter("category1",info.category1),
                                new SqlParameter("category2",info.category2),
                                new SqlParameter("category3",info.category3),
                                };
            return DBhelp.Create().ExecuteReader(sql, sp: sp);
        }

        public SqlDataReader selectTotal1(string category1)
        {
            string sql = @"select * from BookInfo where category1 = @category1";
            SqlParameter[] sp = {
                                new SqlParameter("category1",category1)
                                };
            return DBhelp.Create().ExecuteReader(sql, sp: sp);
        }

        public SqlDataReader selectTotal2(string category1, string category2)
        {
            string sql = @"select * from BookInfo where category1 = @category1 and category2 = @category2";
            SqlParameter[] sp = {
                                new SqlParameter("category1",category1),
                                new SqlParameter("category2",category2),
                                };
            return DBhelp.Create().ExecuteReader(sql, sp: sp);
        }

        public SqlDataReader selectTotal3(string category1, string category2 , string category3)
        {
            string sql = @"select * from BookInfo where category1 = @category1 and category2 = @category2 and category3 = @category3";
            SqlParameter[] sp = {
                                new SqlParameter("category1",category1),
                                new SqlParameter("category2",category2),
                                new SqlParameter("category3",category3),
                                };
            return DBhelp.Create().ExecuteReader(sql, sp: sp);
        }
    }
}
