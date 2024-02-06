using System;
using _1BRChallenge;

namespace _1BRChallengeTest
{
    [TestClass]
    public class UtilsTest
	{
        [TestMethod]
        public void GetConstantResultTest()
        {
            int result = Utils.GetConstantResult();
            Assert.AreEqual(10, result);
        }
    }
}

