using Moq;
using NUnit.Framework;
using Skeleton.Interfaces;
using Skeleton.Tests.FakeObjets;

[TestFixture]
public class HeroTests
{
    //private string name;
    //private int experience;

    //private Axe weapon;
    //private int attackPoints;
    //private int durabilityPoints;

    //private int health;
    //[SetUp]
    //public void SetUp()
    //{
    //    this.name = "Kaiovasa";
    //    this.experience = 100;
    //    this.attackPoints = 10;
    //    this.durabilityPoints = 10;
    //    this.weapon = new Axe(attackPoints, durabilityPoints);
    //    Hero hero = new Hero(name,weapon);
    //    this.health = 100;
    //    var dummy = new Dummy(health, experience);

    //}

    //[Test]
    //public void AssertWhemTargetIsAtaclWeponLoseDurabilityPostions()
    //{
    //    var hero = new Hero(name, weapon);
    //    var dummy = new Dummy(100, 100);
    //    hero.Attack(dummy);
    //    Assert.AreEqual(weapon.DurabilityPoints - 1, 8);
       
    //}

    //[Test]
    //public void WhenDummyISAtackedFormHeroShouldLoseHealth()
    //{
    //    var hero = new Hero(name, weapon);
    //    var dummy = new Dummy(health, experience);
    //    hero.Attack(dummy);
    //    Assert.AreEqual(dummy.Health, 90);
    //}

    //[Test]

    //public void AssertThatWhenDummyDieSholudGIveExperciance()
    //{
    //    var dummy = new Dummy(1, experience);
    //    var wepon = new Axe(1000, 100);
    //    var hero = new Hero(name, weapon);
    //    hero.Attack(dummy);
    //    Assert.IsTrue(dummy.GiveExperience()==hero.Experience);
    //}

    //[Test]
    //public void AssertThat_WhenTargetDieHero_ShouldIncereaseLeverlExperiance()
    //{
    //    FakeTarget target = new FakeTarget();

    //    FakeWeapon weapon = new FakeWeapon();
    //    var heroName = "Kaiovasa";
    //    Hero hero = new Hero(heroName, weapon);
    //    hero.Attack(target);
    //    Assert.That(hero.Experience, Is.EqualTo(20));
    //}
    [Test]
    public void whenHeroKilssTargetShouldIncreaseXP()
    {
        Mock<ITarget> MTarget = new Mock<ITarget>();
        MTarget.Setup(t => t.IsDead()).Returns(true);
        MTarget.Setup(t => t.GiveExperience()).Returns(10);

        Mock<IWepon> MockWeapon = new Mock<IWepon>();
        
        var heroName = "Kaiovasa";
        Hero hero = new Hero(heroName, MockWeapon.Object);
        hero.Attack(MTarget.Object);


        Assert.That(hero.Experience, Is.EqualTo(10));
    }

}