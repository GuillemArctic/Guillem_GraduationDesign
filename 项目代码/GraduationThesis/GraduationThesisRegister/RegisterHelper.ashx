<%@ WebHandler Language="C#" Class="RegisterHelper" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class RegisterHelper : IHttpHandler
{
    public string strcon = "data source=.;initial catalog=GraduationThesis;user id=sa;password=123456";

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string Result = context.Request.Form["RegisterMessage"];
        string[] sArray = Result.Split('#');
        if (sArray[5] != sArray[6])
            context.Response.Write("密码不一致！注册失败");
        else
        {
            try
            {
                string id = null;
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    //获取登录编号
                    SqlCommand command = new SqlCommand("select top 1 * from User_Login order by UserLogin_ID desc", con);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                        id = (int.Parse(dr[0].ToString()) + 1).ToString();
                    dr.Close();
                    //填写用户信息表
                    SqlCommand command0 = new SqlCommand("insert into User_RegisteInfo values(@UserLogin_ID,@UserRegiste_Name,@UserRegiste_Sex,@UserRegiste_Phone,@UserRegiste_Cardid,@UserRegiste_Email)", con);
                    command0.Parameters.Add("UserLogin_ID", SqlDbType.NVarChar).Value = id;
                    command0.Parameters.Add("UserRegiste_Name", SqlDbType.NVarChar).Value = sArray[0];
                    command0.Parameters.Add("UserRegiste_Sex", SqlDbType.NVarChar).Value = sArray[1];
                    command0.Parameters.Add("UserRegiste_Phone", SqlDbType.NVarChar).Value = sArray[2];
                    command0.Parameters.Add("UserRegiste_Cardid", SqlDbType.NVarChar).Value = sArray[3];
                    command0.Parameters.Add("UserRegiste_Email", SqlDbType.NVarChar).Value = sArray[4];
                    command0.ExecuteNonQuery();
                    //填写注册表
                    SqlCommand command1 = new SqlCommand("insert into User_Login values(@UserLogin_Name,@UserLogin_Password)", con);
                    command1.Parameters.Add("UserLogin_Name", SqlDbType.NVarChar).Value = sArray[0];
                    command1.Parameters.Add("UserLogin_Password", SqlDbType.NVarChar).Value = sArray[5];
                    command1.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {
                context.Response.Write("注册失败!");
            }
            context.Response.Write("注册成功!");

        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}