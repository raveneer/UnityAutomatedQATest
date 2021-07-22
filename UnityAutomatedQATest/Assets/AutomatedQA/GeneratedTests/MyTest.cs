using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace GeneratedRecordedTests
{
    public class MyTest : SimpleButtonDown_Tests
    {
        [UnityTest]
        public IEnumerator MyTestCase()
        {
            yield return CanPlayToEnd();
            Assert.Fail();
        }
    }
}