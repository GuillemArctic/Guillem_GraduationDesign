using GraduationThesis.Data;
using GraduationThesis.Model;
using GraduationThesis.OtherWindow;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GraduationThesis
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Window_Login window_Login = new Window_Login();
            window_Login.ShowDialog();
            if (window_Login.DialogResult == true)
            {
                InitData();
            }
        }

        private void InitData()
        {

            MultiCmb.ItemsSource = MultiComboBoxList.Instance.MultiComboBoxListData;
            TreeViewOrg.ItemsSource = TreeviewDataInit.Instance.OrgList;
            DataGrid.ItemsSource = DataGridDataInit.Instance.StudentList;
            ListView.ItemsSource = ListViewDataInit.Instance.ListViewDataList;
            UserInfoList.ItemsSource = ListBoxDataInit.Instance.UserList;

            //TODO:查询数据库填充DataGrid,目前为Test数据(可用于后期软件测试)
        }
        /// <summary>
        /// 项目展示-项目详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_LookInfo_Click(object sender, RoutedEventArgs e)
        {
            //TODO :展示项目的详细信息
            Window_InfoShow window_InfoShow = new Window_InfoShow("项目展示-项目详情", "项目详情","Page_ProjectInfo");
            window_InfoShow.ShowDialog();
        }
        
        private void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        /// <summary>
        /// 编辑部门信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Btn_Delete.Visibility = Visibility.Visible;
            Btn_Save.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// 删除部门信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            Btn_Delete.Visibility = Visibility.Hidden;
            Btn_Save.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Add项目信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_Add_MouseDown(object sender, MouseButtonEventArgs e)
        {
            wra.Visibility = Visibility.Hidden;
            Progrid.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            wra.Visibility = Visibility.Visible;
            Progrid.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// 保存项目信息到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_addProject_Click(object sender, RoutedEventArgs e)
        {
            Window_Error window_Error = new Window_Error("添加项目","保存成功!");
            window_Error.Show();
            wra.Visibility = Visibility.Visible;
            Progrid.Visibility = Visibility.Hidden;
        }
    }
}
