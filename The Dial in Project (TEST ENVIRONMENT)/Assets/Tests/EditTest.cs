using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class EditTest
{
    [UnityTest]
    public IEnumerator EspressoMachine_StartBrewing_SetsIsBrewingTrue()
    {
        var espressoMachine = new GameObject().AddComponent<EspressoMachine>();
        espressoMachine.StartBrewing();

        yield return null; // Wait a frame for Unity to process changes

        Assert.IsTrue(SimManager.Instance.isBrewing, "StartBrewing did not set isBrewing to true.");
    }
}