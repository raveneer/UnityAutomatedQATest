using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using Unity.CloudTesting;

namespace GeneratedRecordedTests
{
    /// <summary>
    /// These tests were generated by Unity Automated QA for the recording from the Assets folder at "\Recordings\FirstTest.json".
    /// You can regenerate this file from the Unity Editor Menu: Automated QA > Generate Recorded Tests
    /// </summary>
    public class FirstTest_Tests : AutomatedQATestsBase
    {
        /// Generated from recording file: "\Recordings\FirstTest.json".
        [CloudTest]
        [UnityTest]
        public IEnumerator CanPlayToEnd()
        {
            yield return PerformAction(FirstTest_Steps.Actions["PRESS_Button"]); // Do a "press" action on "Canvas/Button" in scene "SampleScene".
            yield return PerformAction(FirstTest_Steps.Actions["RELEASE_Button"]); // Do a "release" action on "Canvas/Button" in scene "SampleScene".
            yield return PerformAction(FirstTest_Steps.Actions["PRESS_Button_2"]); // Do a "press" action on "Canvas/Button" in scene "SampleScene".
            yield return PerformAction(FirstTest_Steps.Actions["RELEASE_Button_2"]); // Do a "release" action on "Canvas/Button" in scene "SampleScene".
            yield return PerformAction(FirstTest_Steps.Actions["PRESS_Button_3"]); // Do a "press" action on "Canvas/Button" in scene "SampleScene".
            yield return PerformAction(FirstTest_Steps.Actions["RELEASE_Button_3"]); // Do a "release" action on "Canvas/Button" in scene "SampleScene".
            yield return PerformAction(EMIT_COMPLETE); // Test complete.
        }

        // Steps defined by recording.
        protected override void SetUpTestClass()
        {
            RegisterStep(FirstTest_Steps.Actions["PRESS_Button"]);
            RegisterStep(FirstTest_Steps.Actions["RELEASE_Button"]);
            RegisterStep(FirstTest_Steps.Actions["PRESS_Button_2"]);
            RegisterStep(FirstTest_Steps.Actions["RELEASE_Button_2"]);
            RegisterStep(FirstTest_Steps.Actions["PRESS_Button_3"]);
            RegisterStep(FirstTest_Steps.Actions["RELEASE_Button_3"]);
        }

        // Initialize test run data.
        protected override void SetUpTestRun()
        {
            Test.entryScene = "SampleScene";
            Test.recordedAspectRatio = new Vector2(1110f,567f);
            Test.recordedResolution = new Vector2(1920f,1080f);
        }
    }
}
