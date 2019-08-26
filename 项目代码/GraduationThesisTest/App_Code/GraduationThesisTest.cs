using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;


/// <summary>
/// GraduationThesisTest 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
// [System.Web.Script.Services.ScriptService]
public class GraduationThesisTest : System.Web.Services.WebService
{
    public GraduationThesisTest()
    {
        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    public string strcon = "data source=.;initial catalog=GraduationThesis;user id=sa;password=123456";

    /// <summary>
    /// Insert用户信息表
    /// </summary>
    /// <param name="UserRegiste_Name">4132</param>
    /// <param name="UserRegiste_Sex"></param>
    /// <param name="UserRegiste_Phone"></param>
    /// <param name="UserRegiste_Cardid"></param>
    /// <param name="UserRegiste_Email"></param>
    /// <returns></returns>
    [WebMethod(Description ="123\r\n45")]
    public string Insert_User_RegisteInfo(string UserRegiste_Name, string UserRegiste_Sex, string UserRegiste_Phone, string UserRegiste_Cardid, string UserRegiste_Email)
    {
        string Login_id = GetLoginid();
        try
        {
            //检测Login_id是否正常
            int id = int.Parse(Login_id);
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    //填写用户信息表
                    SqlCommand command = new SqlCommand("insert into User_RegisteInfo values(@UserLogin_ID,@UserRegiste_Name,@UserRegiste_Sex,@UserRegiste_Phone,@UserRegiste_Cardid,@UserRegiste_Email)", con);
                    command.Parameters.Add("UserLogin_ID", SqlDbType.NVarChar).Value = Login_id;

                    command.Parameters.Add("UserRegiste_Name", SqlDbType.NVarChar).Value = UserRegiste_Name;
                    command.Parameters.Add("UserRegiste_Sex", SqlDbType.NVarChar).Value = UserRegiste_Sex;
                    command.Parameters.Add("UserRegiste_Phone", SqlDbType.NVarChar).Value = UserRegiste_Phone;
                    command.Parameters.Add("UserRegiste_Cardid", SqlDbType.NVarChar).Value = UserRegiste_Cardid;
                    command.Parameters.Add("UserRegiste_Email", SqlDbType.NVarChar).Value = UserRegiste_Email;
                    command.ExecuteNonQuery();
                    con.Close();
                    return Insert_User_Login(UserRegiste_Name, "000000");
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        catch
        {
            return Login_id;
        }
    }
    /// <summary>
    /// Select用户信息表
    /// </summary>
    /// <param name="UserRegiste_Name"></param>
    /// <param name="UserRegiste_Sex"></param>
    /// <param name="UserRegiste_Phone"></param>
    /// <param name="UserRegiste_Cardid"></param>
    /// <param name="UserRegiste_Email"></param>
    /// <returns></returns>
    [WebMethod]
    public string Select_Insert_User_RegisteInfo(string UserRegiste_Name, string UserRegiste_Sex, string UserRegiste_Phone, string UserRegiste_Cardid, string UserRegiste_Email)
    {
        return "";
    }
    /// <summary>
    /// Insert登录信息表
    /// </summary>
    /// <returns></returns>
    private string Insert_User_Login(string username, string password)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into User_Login values(@UserLogin_Name,@UserLogin_Password)", con);
                command.Parameters.Add("UserLogin_Name", SqlDbType.NVarChar).Value = username;
                command.Parameters.Add("UserLogin_Password", SqlDbType.NVarChar).Value = password;
                command.ExecuteNonQuery();
                con.Close();
            }
            List<User_LoginInfo> user_LoginInfos = new List<User_LoginInfo>();
            User_LoginInfo user_LoginInfo = new User_LoginInfo();
            user_LoginInfo.Result = "注册成功!请登录系统进行密码重置!";
            user_LoginInfo.Name = "用户名:" + username;
            user_LoginInfo.Password = "初始密码:" + password;
            user_LoginInfos.Add(user_LoginInfo);
            return JsonConvert.SerializeObject(user_LoginInfos);
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    /// <summary>
    /// 获取登录ID
    /// </summary>
    /// <returns></returns>
    private string GetLoginid()
    {
        string id = null;
        try
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                //获取登录编号
                SqlCommand command = new SqlCommand("select top 1 * from User_Login order by UserLogin_ID desc", con);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                    id = (int.Parse(dr[0].ToString()) + 1).ToString();
                dr.Close();
                con.Close();
            }
            return id;
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    /// <summary>
    /// 登录User_LoginInfo实体
    /// </summary>
    public class User_LoginInfo
    {
        public string Result { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
    /// <summary>
    /// 用户信息实体
    /// </summary>
    public class User_RegisteInfo
    {
        public string UserLogin_ID { get; set; }
        public string UserRegiste_Name { get; set; }
        public string UserRegiste_Sex { get; set; }
        public string UserRegiste_Phone { get; set; }
        public string UserRegiste_Cardid { get; set; }
        public string UserRegiste_Email { get; set; }
    }
}
