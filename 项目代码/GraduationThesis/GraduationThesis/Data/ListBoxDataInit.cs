using GraduationThesis.Model;
using System.Collections.Generic;
using System.Windows.Media;

namespace GraduationThesis.Data
{
    public class ListBoxDataInit
    {
        private static ListBoxDataInit dataInit;

        public static ListBoxDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new ListBoxDataInit();
                return dataInit;
            }
        }

        private ListBoxDataInit()
        {
            UserList = new List<UserInfo>()
            {
                new UserInfo(){
                    UserBackground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff9f4c")),
                    Header="东",
                    Name="华东区",
                    Info="智慧草坪项目",
                    Count=52
                },
                new UserInfo(){
                    UserBackground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff9f4c")),
                    Header="南",
                    Name="华南区",
                    Info="智能商超管理系统",
                    Count=25
                },
                new UserInfo(){
                    UserBackground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d9d9d")),
                    Header="北",
                    Name="华北区",
                    Info="智能商超管理系统!",
                    Count=15
                },
            };
        }
        public List<UserInfo> UserList { get; set; }
    }
}
