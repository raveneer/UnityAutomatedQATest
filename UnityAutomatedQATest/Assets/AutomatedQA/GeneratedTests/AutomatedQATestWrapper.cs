using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace GeneratedRecordedTests
{
    public class AutomatedQATestWrapper : FirstTest_Tests
    {
        [UnityTest]

        public IEnumerator CanPlayToEnd_ContainTest()
        {
            yield return CanPlayToEnd();

            Assert.Fail();
        }
    }
}