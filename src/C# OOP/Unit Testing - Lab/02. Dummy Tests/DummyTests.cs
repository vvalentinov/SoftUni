﻿using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShouldLoseHealthIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);

        //Act
        dummy.TakeAttack(10);

        //Assert
        var expectedResult = 90;
        var actualtResult = dummy.Health;
        Assert.AreEqual(expectedResult, actualtResult);
    }
    [Test]
    public void DeadDummyShouldThrowExceptionIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }

    [Test]
    public void DeadDummyShouldGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);

        //Act - Assert
        var expectedResult = 100;
        var actualResult = dummy.GiveExperience();
        Assert.AreEqual(expectedResult, actualResult);  
    }
    [Test]
    public void AliveDummyShouldNotGiveXp()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
