using System;
using DotaAnalyst.Utils;
using NUnit.Framework;

namespace TestingAnalytics
{
    [TestFixture()]
    public class CreateResourcesTests
    {
        [Test()]
        public void CreateResources_true()
        {
            bool res = CreateResources.Create();
            Assert.AreEqual(res, true);
        }
    }
}
