using GraduationThesis.Model;
using System.Collections.Generic;

namespace GraduationThesis.Data
{
    public class DataGridDataInit
    {
        private static DataGridDataInit dataInit;

        public static DataGridDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new DataGridDataInit();
                return dataInit;
            }
        }

        private DataGridDataInit()
        {
            StudentList = new List<StudentInfo>()
            {
                new StudentInfo()
                {
                    ProjectID = 1,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华东区",
                    ProjectStarttime="2018-10-02",
                    ProjectStoptime="2020-09-13",
                    ProjectMainstff="刘雨晴",
                    ProjectValue =15
                },
                new StudentInfo()
                {
                    ProjectID = 2,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华东区",
                    ProjectStarttime="2018-03-11",
                    ProjectStoptime="2019-09-13",
                    ProjectMainstff="云冰心",
                    ProjectValue =37
                },
                new StudentInfo()
                {
                    ProjectID = 3,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华北区",
                    ProjectStarttime="2016-01-02",
                    ProjectStoptime="2019-12-13",
                    ProjectMainstff="天九儿",
                    ProjectValue =5
                },
                new StudentInfo()
                {
                    ProjectID = 4,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华南区",
                    ProjectStarttime="2015-10-02",
                    ProjectStoptime="2020-09-13",
                    ProjectMainstff="赵茜",
                    ProjectValue =35
                },
                new StudentInfo()
                {
                    ProjectID = 5,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华北区",
                    ProjectStarttime="2019-10-02",
                    ProjectStoptime="2022-12-25",
                    ProjectMainstff="雪倾城",
                    ProjectValue =50
                },
                new StudentInfo()
                {
                    ProjectID = 6,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华东区",
                    ProjectStarttime="2018-12-31",
                    ProjectStoptime="2019-02-13",
                    ProjectMainstff="牧中平",
                    ProjectValue =60
                },
                new StudentInfo()
                {
                    ProjectID = 7,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华北区",
                    ProjectStarttime="2017-06-02",
                    ProjectStoptime="2018-10-12",
                    ProjectMainstff="兰芝韵",
                    ProjectValue =45
                },
                new StudentInfo()
                {
                    ProjectID = 8,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="西南区",
                    ProjectStarttime="2018-10-02",
                    ProjectStoptime="2020-09-13",
                    ProjectMainstff="唐珂",
                    ProjectValue =31
                },
                new StudentInfo()
                {
                    ProjectID = 9,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="西南区",
                    ProjectStarttime="2016-04-02",
                    ProjectStoptime="2018-08-11",
                    ProjectMainstff="白小飞",
                    ProjectValue =11
                },
                new StudentInfo()
                {
                    ProjectID = 10,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华东区",
                    ProjectStarttime="2018-09-02",
                    ProjectStoptime="2020-09-13",
                    ProjectMainstff="夏一天",
                    ProjectValue =9
                },
                new StudentInfo()
                {
                    ProjectID = 11,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="西南区",
                    ProjectStarttime="2017-05-01",
                    ProjectStoptime="2018-12-13",
                    ProjectMainstff="刘紫衣",
                    ProjectValue =26
                },
                new StudentInfo()
                {
                    ProjectID = 12,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="西北区",
                    ProjectStarttime="2018-10-02",
                    ProjectStoptime="2020-09-13",
                    ProjectMainstff="夏惜君",
                    ProjectValue =91
                },
                new StudentInfo()
                {
                    ProjectID = 13,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华中区",
                    ProjectStarttime="2018-10-02",
                    ProjectStoptime="2020-09-13",
                    ProjectMainstff="李陌尘",
                    ProjectValue =68
                },
                new StudentInfo()
                {
                    ProjectID = 14,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华中区",
                    ProjectStarttime="2018-10-15",
                    ProjectStoptime="2019-11-03",
                    ProjectMainstff="宋婉仪",
                    ProjectValue =56
                },
                new StudentInfo()
                {
                    ProjectID = 15,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华南区",
                    ProjectStarttime="2018-02-01",
                    ProjectStoptime="2019-10-13",
                    ProjectMainstff="周璇",
                    ProjectValue =23
                },
                new StudentInfo()
                {
                    ProjectID = 16,
                    ProjectName = "智能商超管理系统",
                    ProjectArea="华中区",
                    ProjectStarttime="2018-06-13",
                    ProjectStoptime="2019-07-25",
                    ProjectMainstff="李断月",
                    ProjectValue =75
                }
            };
        }
        public List<StudentInfo> StudentList { get; set; }
    }
}
