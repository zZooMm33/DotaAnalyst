using System;
using System.Configuration;
using DotaAnalyst.Utils;

namespace DotaAnalyst.Database
{
    public class Connection
    {
        public static void GetConnection()
        {            
            switch (ConfigurationManager.AppSettings[AppConfigConst.DATA_BASE_TYPE])
            {
                case "xml":
                    {
                        // ничего не требуется возвращать
                    }break;
                case "sql":
                    {
                        string url = ConfigurationManager.AppSettings[AppConfigConst.DATA_BASE_URL];
                        string login = ConfigurationManager.AppSettings[AppConfigConst.LOGIN_DATA_BASE];
                        string pas = ConfigurationManager.AppSettings[AppConfigConst.PAS_DATA_BASE];
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
