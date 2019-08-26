using GraduationThesis.OtherWindow;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraduationThesis.UserControls
{
    /// <summary>
    /// LoginButton.xaml 的交互逻辑
    /// </summary>
    public partial class LoginButton : UserControl
    {
        public LoginButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 调出系统设置界面进行设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window_Setting window_Setting = new Window_Setting();
            window_Setting.ShowDialog();
        }
        /// <summary>
        /// 窗口最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 退出应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
