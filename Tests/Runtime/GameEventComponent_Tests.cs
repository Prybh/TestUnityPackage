using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GameEventComponentTests
{
    [Test]
    public void GameEventComponentTests_Empty()
    {
        LogAssert.ignoreFailingMessages = true;

        GameObject gameObject = new GameObject();
        GameEventComponent comp = gameObject.AddComponent<GameEventComponent>();
        comp.Invoke("Test");
    }
}
