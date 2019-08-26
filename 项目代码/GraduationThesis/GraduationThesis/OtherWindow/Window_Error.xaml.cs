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
    /// Window_Error.xaml 的交互逻辑
    /// </summary>
    public partial class Window_Error : Window
    {
        public Window_Error(string MessageTitle,string Message)
        {
            InitializeComponent();
            lb_MessageTitle.Content = MessageTitle;
            lb_Message.Content = Message;
        }

        private void Btn_Confirm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
