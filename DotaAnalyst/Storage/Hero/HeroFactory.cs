using System;
using System.Configuration;
using DotaAnalyst.Utils;

namespace DotaAnalyst.Database
{
    public class HeroFactory
    {
        public static IHeroDAO FactoryMethod()
        {

            switch (ConfigurationManager.AppSettings[AppConfig.DATA_BASE_TYPE])
            {
                case "xml":
                    {
                        return new HeroXML();
                    }
                    break;
                case "sql":
                    {
                        return new HeroSQL();
                    }
                    break;
                default:
                    break;
            }

            return null;
        }
    }
}
