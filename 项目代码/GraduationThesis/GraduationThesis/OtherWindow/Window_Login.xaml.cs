using GraduationThesis.Data;
using GraduationThesis.OtherWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GraduationThesis
{
    /// <summary>
    /// Window_Login.xaml 的交互逻辑
    /// </summary>
    public partial class Window_Login : Window
    {
        public string LoginType = "";
        public string LoginReslt = "";
        public Window_Login()
        {
            this.PictureOfGif.Image = System.Drawing.Image.FromFile("Images/back.gif");
            InitializeComponent();
            //TODO:尝试加载已经保存的账号以及密码
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
            //this.Dispatcher.Invoke(new Action(()=>
            //{
            //    if (rember_ck.IsChecked == true)
            //    { 
            //        //TODO：保存password
            //    }
            //}));
            //SQLHelper sQLHelper = new SQLHelper();
            //if(sQLHelper.GetLogin(txt_Name.Text,txt_Password.Text))
            //{
            //    this.DialogResult = true;
            //    this.Close();
            //}
            //else
            //{
            //    LoginType = "错误提示";
            //    LoginReslt = "登录失败！请检查用户名和密码";
            //    Window_Error window_Error = new Window_Error(LoginType, LoginReslt);
            //    window_Error.ShowDialog();
            //}
                
        }

        /// <summary>
        /// 创建或获取用户数据基本路径
        /// </summary>
        /// <returns></returns>
        private string Getpath(string filename)
        {
            string path = @AppDomain.CurrentDomain.BaseDirectory + "User_Data\\"+filename;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }

        private void txt_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Name.Text = "";
        }

        private void txt_Password_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Password.Text = "";
        }
        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("ChromeCore.exe", "http://localhost:53961/MainRegister.aspx");
        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("ChromeCore.exe", "http://localhost:53961/forgot.html");
        }
    }
}
