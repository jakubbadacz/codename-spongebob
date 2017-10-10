using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestEngine
{

	[Test]
	public void TestTryToTurnEngineOnWhenOn()
    {
        Engine engine = new Engine();
        engine.SetIsOn(true);

        bool expectedResult = false;
        Assert.AreEqual(expectedResult, engine.TurnOnEngine());
	}

    [Test]
    public void TestTryToTurnEngineOffWhenOff()
    {
        Engine engine = new Engine();
        engine.SetIsOn(false);

        bool expectedResult = false;
        Assert.AreEqual(expectedResult, engine.TurnOffEngine());
    }
}
