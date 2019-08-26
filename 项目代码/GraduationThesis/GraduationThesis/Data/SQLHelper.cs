using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GraduationThesis.Data
{
    class SQLHelper
    {
        public string strcon = "data source=.;initial catalog=GraduationThesis;user id=sa;password=123456";

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool GetLogin(string username,string password)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from User_Login Where UserLogin_Name=@name and UserLogin_Password=@password", con);
            cmd.Parameters.Add("name",SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("password",SqlDbType.NVarChar).Value = password;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
        }

    }
}
