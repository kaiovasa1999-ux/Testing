using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    private int health;
    private int experience;
    private Dummy dummy;
    [SetUp]
    public void Setup()
    {
        this.health = 150;
        this.experience = 15;
        var dummy = new Dummy(health, experience);
    }
    [Test]
    public void AssertDummyCanTakeAtacks() 
    {
        var dummy = new Dummy(health, experience);
        dummy.TakeAttack(100);
        Assert.AreEqual(dummy.Health, 50);
    }

    [Test]
    public void AssertThatDummyCannotGiveXP_whenIsAlive()
    {
        var dummy = new Dummy(health, experience);
        //var x = dummy.GiveExperience();
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }

    [Test]
    public void Assert_ThatDummyIsDead_WhenHealthIsZeroOrNegative()
    {
        var dummy = new Dummy(0, 1111);
        var x = dummy.IsDead();
        Assert.AreEqual(x, true);
    }
}
