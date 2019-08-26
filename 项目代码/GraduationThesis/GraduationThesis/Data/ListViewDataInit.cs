using GraduationThesis.Model;
using System.Collections.Generic;

namespace GraduationThesis.Data
{
    public class ListViewDataInit
    {
        private static ListViewDataInit dataInit;

        public static ListViewDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new ListViewDataInit();
                return dataInit;
            }
        }

        private ListViewDataInit()
        {
            ListViewDataList = new List<ListViewData>();
            for (int i = 0; i < 10; i++)
            {
                ListViewDataList.Add(new ListViewData()
                {
                    Num = i,
                    Name = "代办_" + i.ToString(),
                    Template = "J4-510开会:" + i.ToString()
                });
            }
        }
        public List<ListViewData> ListViewDataList { get; set; }
    }
}
