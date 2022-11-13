using NUnit.Framework;
using SWINADVENTURE;

namespace BagTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestTestBagLocatesItems()
        {

            Bag bag = new Bag(new string[] { "weapon" }, "assault weapon", "attack use");
            Item food = new Item(new string[] { "food" }, "berries", "consume");
            bag.inventory.Put(food);

            Assert.IsTrue(bag.Locate("food").FirstId == food.FirstId);
        }

        [Test]
        public void TestBagLocatesItself()
        {
            Bag bag = new Bag(new string[] { "weapon" }, "assault weapon", "attack use");
            Assert.IsTrue(bag.Locate("weapon") == bag);
        }

        [Test]
        public void TestBagLocatesNothing()
        {
            Bag bag = new Bag(new string[] { "weapon" }, "assault weapon", "attack use");
            Assert.IsTrue(bag.Locate("food") == null);
        }
        [Test]
        public void TestBagFullDescription()
        {
            Bag bag = new Bag(new string[] { "weapon" }, "assault weapon", "attack use");
            Assert.IsTrue((bag.Name + bag.inventory.ItemList) == bag.FullDescription);
        }
        [Test]
        public void TestBaginBag()
        {
            //Bag 1 
            Bag bag1 = new Bag(new string[] { "weapon" }, "assault", "attack use");
            //Bag 2
            Bag bag2 = new Bag(new string[] { "food" }, "healing", "comsumeable");
            Item armour = new Item(new string[] { "armour" }, "protection", "protect");

            //insert armour in to bag
            bag1.inventory.Put(armour);
            //check if insert bag 1 item into bag 2
            Assert.IsTrue(bag2.Locate("food") == bag2);
            //check if insert armour into bag
            Assert.IsTrue(bag1.Locate("armour") == armour);

            Item gun = new Item(new string[] { "sniper" }, "attack", "long-range");
            bag2.inventory.Put(gun);
            //check bag1 cannot insert item where bag 2 inserted
            Assert.IsFalse(bag1.Locate("sniper") == gun);


        }
    }
}