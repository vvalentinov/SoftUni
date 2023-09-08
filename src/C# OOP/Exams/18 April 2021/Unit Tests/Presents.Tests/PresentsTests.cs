namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        private Bag bag;
        [SetUp]
        public void SetUp()
        {
            this.bag = new Bag();
        }
        [Test]
        public void PresentConstructorShouldWorkCorrectly()
        {
            Present present = new Present("Car", 34.6);
            Assert.AreEqual(present.Name, "Car");
            Assert.AreEqual(present.Magic, 34.6);
        }
        [Test]
        public void BagConstructorShouldWorkCorrectly()
        {
            IReadOnlyCollection<Present> presents = this.bag.GetPresents();
            Assert.AreEqual(presents.Count, 0);
        }
        [Test]
        public void CreateShouldThrowException()
        {
            Exception exception = Assert.Throws<ArgumentNullException>(() => this.bag.Create(null));
            Assert.AreEqual(exception.Message, "Value cannot be null. (Parameter 'Present is null')");
            Present present = new Present("Car", 34.6);
            this.bag.Create(present);
            Exception exception1 = Assert.Throws<InvalidOperationException>(() => this.bag.Create(present));
            Assert.AreEqual(exception1.Message, "This present already exists!");
        }
        [Test]
        public void CreateShouldWorkCorrectly()
        {
            Present car = new Present("Car", 34.6);
            this.bag.Create(car);
            Present truck = new Present("Truck", 55.8);
            string result = this.bag.Create(truck);
            Assert.AreEqual(result, "Successfully added present Truck.");
            IReadOnlyCollection<Present> presents = this.bag.GetPresents();
            Assert.AreEqual(presents.Count, 2);
        }
        [Test]
        public void RemoveShouldWorkCorrectly()
        {
            Present car = new Present("Car", 34.6);
            Present truck = new Present("Truck", 55.8);
            this.bag.Create(car);
            this.bag.Create(truck);
            this.bag.Remove(car);
            bool result = this.bag.Remove(truck);
            Assert.AreEqual(true, result);
            IReadOnlyCollection<Present> presents = this.bag.GetPresents();
            Assert.AreEqual(0, presents.Count);
        }
        [Test]
        public void GetPresentWithLeastMagicShouldWorkCorrectly()
        {
            Present car = new Present("Car", 34.6);
            Present truck = new Present("Truck", 55.8);
            this.bag.Create(car);
            this.bag.Create(truck);
            Present present = this.bag.GetPresentWithLeastMagic();
            Assert.AreEqual(car, present);
        }
        [Test]
        public void GetPresentShouldWorkCorrectly()
        {
            Present car = new Present("Car", 34.6);
            Present truck = new Present("Truck", 55.8);
            this.bag.Create(car);
            this.bag.Create(truck);
            Present present = this.bag.GetPresent("Truck");
            Assert.AreEqual(present, truck);
            Present present1 = this.bag.GetPresent("Santa");
            Assert.AreEqual(null, present1);
        }
    }
}
