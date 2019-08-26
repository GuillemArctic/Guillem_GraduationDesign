using GraduationThesis.Model;
using System.Collections.ObjectModel;

namespace GraduationThesis.Data
{
    public class TreeviewDataInit
    {
        private static TreeviewDataInit dataInit;

        public static TreeviewDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new TreeviewDataInit();
                return dataInit;
            }
        }
        private TreeviewDataInit()
        {
            OrgList = new ObservableCollection<OrgModel>()
            {
                new OrgModel()
                {
                    IsGrouping = true,
                    DisplayName = "华东区(2/7)",
                    Children = new ObservableCollection<OrgModel>()
                    {
                        new OrgModel(){
                            IsGrouping=true,
                            DisplayName="智能商超管理系统项目(2/4)",
                            Children=new ObservableCollection<OrgModel>()
                            {
                                new OrgModel(){
                                    IsGrouping=false,
                                    SurName="刘",
                                    Name="刘雨晴",
                                    Info="18018349053",
                                    Count=10
                                },
                                  new OrgModel(){
                                    IsGrouping=false,
                                    SurName="刘",
                                    Name="赵茜",
                                    Info="13685923465",
                                    Count=9
                                  },
                                new OrgModel(){
                                    IsGrouping=false,
                                    SurName="雪",
                                    Name="雪倾城",
                                    Info="188964325688",
                                    Count=5
                                }
                            }
                        },
                         new OrgModel(){
                            IsGrouping=true,
                            DisplayName="智能家居系统项目(2/4)",
                            Children=new ObservableCollection<OrgModel>()
                            {
                                new OrgModel(){
                                    IsGrouping=false,
                                    SurName="云",
                                    Name="云冰心",
                                    Info="1886659341",
                                    Count=4
                                }
                            }
                        }
                    },
                },
                new OrgModel()
                {
                    IsGrouping = true,
                    DisplayName = "华南区(2/7)",
                    Children = new ObservableCollection<OrgModel>()
                    {
                        new OrgModel(){
                            IsGrouping=true,
                            DisplayName="智能商超管理系统项目(2/4)",
                            Children=new ObservableCollection<OrgModel>()
                            {
                                new OrgModel(){
                                    IsGrouping=false,
                                    SurName="牧",
                                    Name="牧中平",
                                    Info="18018349053",
                                    Count=5
                                },
                                  new OrgModel(){
                                    IsGrouping=false,
                                    SurName="兰",
                                    Name="兰芝韵",
                                    Info="13685923465",
                                    Count=7
                                  },
                                new OrgModel(){
                                    IsGrouping=false,
                                    SurName="唐",
                                    Name="唐珂",
                                    Info="188964325688",
                                    Count=6
                                }
                            }
                        },
                         new OrgModel(){
                            IsGrouping=true,
                            DisplayName="智能家居系统项目(2/4)",
                            Children=new ObservableCollection<OrgModel>()
                            {
                                new OrgModel(){
                                    IsGrouping=false,
                                    SurName="白",
                                    Name="白小飞",
                                    Info="1886659341",
                                    Count=3
                                }
                            }
                        }
                    },
                }

            };
        }
        public ObservableCollection<OrgModel> OrgList { get; set; }

    }
}
