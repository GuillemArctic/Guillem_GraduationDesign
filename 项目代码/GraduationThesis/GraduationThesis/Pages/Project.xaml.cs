using System.Windows.Controls;

namespace GraduationThesis.Pages
{
    /// <summary>
    /// Interaction logic for Project.xaml
    /// </summary>
    public partial class Project : Page
    {
        public Project(string id)
        {
            InitializeComponent();
            GetGrid(id);
        }

        private void GetGrid(string id)
        {
            switch (id)
            {
                case "Info":
                    Grid_Info.Visibility = System.Windows.Visibility.Visible;
                    Grid_Add.Visibility = System.Windows.Visibility.Hidden;
                    break;
                case "Add":
                    Grid_Info.Visibility = System.Windows.Visibility.Hidden;
                    Grid_Add.Visibility = System.Windows.Visibility.Visible;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 确认信息关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Submit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
          
        }
    }
}
