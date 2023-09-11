using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SlopKitchenServiceTests
{
    private SlopKitchenService _service;

    [SetUp]
    public void Setup()
    {
        _service = new();
    }
    // A Test behaves as an ordinary method
    [Test]
    public void SlopKitchenServiceCorrectlyInitializesValues()
    {
        Assert.IsTrue(_service.SlopPerClick.Equals(1));
        Assert.IsTrue(_service.PotsOfSlop.Equals(0));
    }

    [Test]
    public void SlopKitchenServiceIncrementSpotsOfSlopBySlopPerClickValue()
    {
        _service.SlopButtonClick();
        float firstSlopCount = _service.PotsOfSlop;
        _service.SlopPerClick = 0;
        _service.SlopButtonClick();
        float secondSlopCount = _service.PotsOfSlop;
        _service.SlopPerClick = 68;
        _service.SlopButtonClick();

        Assert.AreEqual(firstSlopCount, 1);
        Assert.AreEqual(secondSlopCount, firstSlopCount);
        Assert.AreEqual(_service.PotsOfSlop, 69);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator GameTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
