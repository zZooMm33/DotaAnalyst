using System;
using DotaAnalyst.Database;
using NUnit.Framework;

namespace TestingAnalytics
{
    [TestFixture()]
    public class HeroTests
    {
        [Test()]
        public void GetHeroes_NotNull()
        {
            var res = HeroInstance.getHero().GetHeroes();
            Assert.NotNull(res);
        }
    }
}
