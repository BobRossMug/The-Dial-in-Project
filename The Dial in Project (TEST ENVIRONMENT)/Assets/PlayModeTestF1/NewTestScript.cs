using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EditTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void EditTestSimplePasses() {
            
            int a = 2;
            int b = 2;
            int result = a + b;

            // Use the Assert class to test conditions
            Assert.AreEqual(4, result, "Expected 2 + 2 to be 4");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator EditTestWithEnumeratorPasses() {
            // For demonstration: we create a temporary GameObject and verify it exists over frames
            GameObject tempObj = new GameObject("TestObject");

            // Use the Assert class to test conditions
            Assert.IsNotNull(tempObj, "TempObj should not be null after creation.");

            // Use yield to skip a frame. This simulates waiting for a frame in Edit Mode.
            yield return null;

            // Optionally, destroy the object or check something else after a frame
            Object.DestroyImmediate(tempObj);
            yield return null;

            // At this point, the tempObj should be destroyed
            Assert.Pass("Enumerator test completed successfully");
        } /* End EditTestWithEnumeratorPasses */ 
    }
}