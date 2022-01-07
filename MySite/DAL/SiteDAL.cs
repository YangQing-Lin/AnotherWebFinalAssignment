using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace MySite
{
    public class SiteDAL
    {
        private SqlConnection sqlcon;
        private SqlCommand sqlcom;
        private string strCon = "server=(local);uid=lqc;pwd=123;database=SCMS";
                
        public DataSet GetUser(string id, string name ,string sex)
        {
            string sqlstr = "select * from UserInfo where 1=1 ";
            if (id != "" && id != null)
            {
                sqlstr = sqlstr + " And (Id = '" + id + "')";
            }
            else
            {
                if (name != "" && name != null)
                {
                    sqlstr = sqlstr + " And (Id like '%" + name + "%' Or name like '%" + name + "%')";
                }
            }
            if (sex != "全部")
            {
                sqlstr = sqlstr + " And Sex='" + sex + "'";
            }
            sqlcon = new SqlConnection(strCon);
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
            DataSet myds = new DataSet();
            sqlcon.Open();
            myda.Fill(myds, "user");            
            sqlcon.Close();
            return myds;
        }

        internal int DeleteSafe(string Id)
        {
            string sqlstr = "delete from CourseInfo where Id='" + Id + "'";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }

        internal DataSet GetSafe(string id ,string name, DateTime? xkrq)
        {
            string sqlstr = "select * from CourseInfo where 1=1 ";
            if (!string.IsNullOrEmpty(id))
            {
                sqlstr = sqlstr + " And (Id = " + id + ")";
            }
            else
            {
                if (name != "" && name != null)
                {
                    sqlstr = sqlstr + " And (Name like '%" + name + "%')";
                }
                if (xkrq!=null)
                {
                    sqlstr = sqlstr + " And (xkrq = '" + xkrq.Value.ToString("yyyy-MM-dd") + "')";
                }
            }
            sqlcon = new SqlConnection(strCon);
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
            DataSet myds = new DataSet();
            sqlcon.Open();
            myda.Fill(myds, "food");
            sqlcon.Close();
            return myds;
        }

        public int DeleteUser(string Id)
        {
            string sqlstr = "delete from UserInfo where Id='" + Id + "'";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result= sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }

        public int UpdateUser(string id, string name, string pwd ,string sex)
        {
            string sqlstr = "update UserInfo set name='" + name + "',Pwd='" + pwd + "',Sex='" + sex + "' where Id='" + id + "'";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
        public int AddUser(string id, string name, string pwd, string sex)
        {
            string sqlstr = "insert into UserInfo(Id,Name,Pwd,Sex)values('" + id + "','" + name + "','" + pwd + "','" + sex + "')";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
        public int UpdateSafe(int id, string name, string kcms, DateTime xkrq, string xkxs)
        {
            string sqlstr = "update CourseInfo set Name='" + name + "',kcms='" + kcms + "',xkrq='" + xkrq.ToString("yyyy-MM-dd")+ "',xkxs='" + xkxs + "' where Id=" + id;
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }


        public int AddSafe(string name, string kcms, DateTime xkrq, string xkxs)
        {
            string sqlstr = "insert into CourseInfo(name,kcms,xkrq,xkxs)values('" + name + "','" + kcms + "','" + xkrq.ToString("yyyy-MM-dd") + "','" + xkxs + "')";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
    }
}