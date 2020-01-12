using System;
using G1_ee_groep1_palamedes.SH_MVL.Web.Services;
using NUnit.Framework;


namespace G1_ee_groep1_palamedes.SH_MVL.UnitTests
{

    public class HasherTest
    {

        private HashingService _hashingService;

        [SetUp]
        public void Setup()
        {
            _hashingService = new HashingService();
        }

        [Test]
        public void ValidHashTest()
        {
            string unhashedstring = "tEstHaSHstIng";
            string expectedResult = "89ED852247602DE5E019D350C42A2DF9";
            string actualResult = _hashingService.Hasher(unhashedstring);
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void InvalidHashTest()
        {
            string unhashedstring = "StRinGtEstHAsh";
            string invalidResult = "BB609547FBA8CA59F082443300A80783";
            string actualResult = _hashingService.Hasher(unhashedstring);

            Assert.AreNotEqual(invalidResult, actualResult);
        }
    }
}