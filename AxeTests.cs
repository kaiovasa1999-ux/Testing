using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private int attackPoints;
    private int durabilityPoints;
    private int health;
    private int experience;
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void SetUp()
    {
        this.attackPoints = 100;
        this.durabilityPoints = 5;
        var axe = new Axe(this.attackPoints, this.durabilityPoints);
        this.health = 110;
        this.experience = 10;
        var dummy = new Dummy(this.health, this.experience);
    }
    [Test]
    public void AssertAxePorpertiesAreSetCorectly()
    {
        var axe = new Axe(attackPoints, durabilityPoints);
        Assert.AreEqual(axe.AttackPoints, 100);
        Assert.AreEqual(axe.DurabilityPoints,5);
    }

    [Test]
    public void Test1()
    {
        var axe = new Axe(attackPoints, durabilityPoints);
        var dummy = new Dummy(health, experience);
        axe.Attack(dummy);
        Assert.AreEqual(axe.DurabilityPoints , 4);
        Assert.AreEqual(dummy.Health , 10);
    }

    [Test]

    public void Assert_AxeCannotAtackWhenDurabilityPoionsAreBelowOne()
    {
        var axe = new Axe(50, 0);
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
    }
}