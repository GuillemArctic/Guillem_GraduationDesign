using GraduationThesis.Pages;
using System.Windows;
using System.Windows.Input;

namespace GraduationThesis.OtherWindow
{
    /// <summary>
    /// Window_InfoShow.xaml 的交互逻辑
    /// </summary>
    public partial class Window_InfoShow : Window
    {
        private string title1 = null;
        public Window_InfoShow(string proinfoTitle, string title, string page)
        {
            InitializeComponent();
            lb_ProinfoTitle.Content = proinfoTitle;
            title1 = title;
            tab.Header = title + "展示";
            GetFramePage(page);
        }

        private void GetFramePage(string page)
        {
            switch (page)
            {
                case "Page_ProjectInfo":
                    Project projectinfo = new Project("Info");
                    FramePage.Content = projectinfo;
                    Btn_Close.Content = "关闭";
                    Btn_Exit.Content = "编辑";
                    break;
                case "Page_ProjectAdd":
                    Project projectadd = new Project("Add");
                    FramePage.Content = projectadd;
                    Btn_Close.Content = "取消";
                    Btn_Exit.Content = "保存";
                    break;
                default:
                    break;
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            if (Btn_Exit.Content.Equals("编辑"))
            {
                Btn_Close.Content = "取消";
                Btn_Exit.Content = "保存";
                tab.Header = title1 + "编辑";
                Project projectadd = new Project("Add");
                FramePage.Content = projectadd;
            }
            else
            {
                Window_Error window_Error = new Window_Error("编辑项目信息","保存成功!");
                window_Error.Show();
            }
        }
    }
}
