using System;
using System.Collections.Generic;
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

namespace GraduationThesis.OtherWindow
{
    /// <summary>
    /// Window_Setting.xaml 的交互逻辑
    /// </summary>
    public partial class Window_Setting : Window
    {
        public Window_Setting()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 调用Webservice验证链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ConnectionTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GraduationThesisWebService.GraduationThesisWebService graduationThesisWebService = new GraduationThesisWebService.GraduationThesisWebService();
                if (graduationThesisWebService.TestLogin())
                {
                    Window_Error window_Error = new Window_Error("连接测试", "连接成功");
                    window_Error.ShowDialog();
                }
            }
            catch (Exception ex )
            {
                Window_Error window_Error = new Window_Error("连接测试", "连接失败！错误日志:"+ex.ToString());
                window_Error.ShowDialog();
            }
           
        }
        
        /// <summary>
        /// 设置服务器的IP链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Set_Click(object sender, RoutedEventArgs e)
        {
            //TODO:书写XML文件
        }

        /// <summary>
        /// 返回到登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗口拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
