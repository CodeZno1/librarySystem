using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BookInfo_BLL
    {
        BookInfo_DAL bf = new BookInfo_DAL();

        public int deleteBookInfo(string id)
        {
            return bf.deleteBookInfo(id);
        }

        public int upadeBookInfo(BookInfo info)
        {
            return bf.updateBookInfo(info);
        }

        public DataTable getAllInfo()
        {
            try
            {
                SqlDataReader objReader = bf.selectBookInfo(); ;
                if (!objReader.HasRows)
                {
                    return null;
                }
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("名字"), new DataColumn("数量"), new DataColumn("类别1"), new DataColumn("类别2"), new DataColumn("类别3"), new DataColumn("地址") });
                while (objReader.Read())
                {
                    dt.Rows.Add(new object[] { Convert.ToString(objReader["ID"]), (string)objReader["name"], Convert.ToString(objReader["count"]), (string)objReader["category1"], (string)objReader["category2"], (string)objReader["category3"], (string)objReader["addr"] });
                }
                objReader.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int addInfo(BookInfo info)
        {
            return bf.AddBookInfo(info);
        }

        public DataTable queryInfo(BookInfo info)
        {
            try
            {
                SqlDataReader objReader = bf.query(info); ;
                if (!objReader.HasRows)
                {
                    return null;
                }
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("名字"), new DataColumn("数量"), new DataColumn("类别1"), new DataColumn("类别2"), new DataColumn("类别3"), new DataColumn("地址") });
                while (objReader.Read())
                {
                    dt.Rows.Add(new object[] { Convert.ToString(objReader["ID"]), (string)objReader["name"], Convert.ToString(objReader["count"]), (string)objReader["category1"], (string)objReader["category2"], (string)objReader["category3"], (string)objReader["addr"] });
                }
                objReader.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getTotal1(string category1)
        {
            try
            {
                int count = 0;
                SqlDataReader objReader = bf.selectTotal1(category1);
                if (!objReader.HasRows)
                {
                    return 0;
                }
                while (objReader.Read())
                {
                    count++;
                }
                objReader.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getTotal2(string category1, string category2)
        {
            try
            {
                int count = 0;
                SqlDataReader objReader = bf.selectTotal2(category1, category2);
                if (!objReader.HasRows)
                {
                    return 0;
                }
                while (objReader.Read())
                {
                    count++;
                }
                objReader.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getTotal3(string category1, string category2, string category3)
        {
            try
            {
                int count = 0;
                SqlDataReader objReader = bf.selectTotal3(category1, category2, category3);
                if (!objReader.HasRows)
                {
                    return 0;
                }
                while (objReader.Read())
                {
                    count++;
                }
                objReader.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
