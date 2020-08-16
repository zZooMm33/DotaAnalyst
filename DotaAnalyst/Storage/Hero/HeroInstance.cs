using System;
using System.Configuration;
using DotaAnalyst.Utils;

namespace DotaAnalyst.Database
{
    public class HeroInstance
    {
        private static IHeroDAO hero = null;


        public static IHeroDAO getHero()
        {
            if (hero == null)
            {
                hero = HeroFactory.FactoryMethod();
            }

            return hero;
        }
    }

}
