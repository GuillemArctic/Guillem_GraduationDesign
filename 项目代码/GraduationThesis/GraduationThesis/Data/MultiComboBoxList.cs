using GraduationThesis.Controls;
using System.Collections.ObjectModel;

namespace GraduationThesis.Data
{
    public class MultiComboBoxList
    {
        private static MultiComboBoxList dataInit;

        public static MultiComboBoxList Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new MultiComboBoxList();
                return dataInit;
            }
        }

        private MultiComboBoxList()
        {
            MultiComboBoxListData = new ObservableCollection<MultiComboBox.MultiCbxBaseData>()
            {
                new MultiComboBox.MultiCbxBaseData(){
                    ID=0,
                    ViewName="刘雨晴",
                    IsCheck=false
                },
                new MultiComboBox.MultiCbxBaseData(){
                    ID=1,
                    ViewName="赵茜",
                    IsCheck=false
                },
                new MultiComboBox.MultiCbxBaseData(){
                    ID=2,
                    ViewName="雪倾城",
                    IsCheck=false
                }
            };
        }
        public ObservableCollection<MultiComboBox.MultiCbxBaseData> MultiComboBoxListData;
    }
}
