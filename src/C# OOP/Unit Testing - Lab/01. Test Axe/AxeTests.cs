using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    [TestCase(100, 100, 100, 100, 99)]
    [TestCase(56, 32, 13, 67, 66)]
    public void DoesWeaponLoseDurabilityAfterAttack(int health, int experience, int attack, int durability, int expectedResult)
    {
        //Arrange
        Dummy dummy = new Dummy(health, experience);
        Axe axe = new Axe(attack, durability);

        //Act
        axe.Attack(dummy);

        //Assert
        var actualResult = axe.DurabilityPoints;
        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void AttackShouldThrowInvalidOperationExceptionWhenAxeDurabilityIsZeroOrBelow()
    {
        //Arrange
        Dummy dummy = new Dummy(10, 10);
        Axe axe = new Axe(20, 0);

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
    }
}