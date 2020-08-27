using System;
using System.Configuration;
using DotaAnalyst.Utils;

namespace DotaAnalyst.Database
{
    public class HeroFactory
    {
        public static IHeroDAO FactoryMethod()
        {
            if (ConfigurationManager.AppSettings[AppConfigConst.DATA_BASE_TYPE].Equals("xml")) return new HeroXML();
            else if (ConfigurationManager.AppSettings[AppConfigConst.DATA_BASE_TYPE].Equals("sql")) return new HeroSQL();
            else return null;
        }
    }
}
