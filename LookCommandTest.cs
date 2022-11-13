using NUnit.Framework;
using SWINADVENTURE;

namespace LookCommandUnitTest
{
    [TestFixture()]
    public class Tests
    {

        Player p;
        Command c;
        Bag b;

        //creating the test object for LookatGems
        Item weapon = new Item(new string[] { "machine gun" }, "guns", "shoot");
        Item amour = new Item(new string[] { "body amour" }, "protect", "protection");
        Item gems = new Item(new string[] { "gems" }, "money", "precious metal");

        [Test()]
        public void TestLookAtMe()
        {
            Player me = new Player("Jason", "are a villian");
            Look_Command look = new Look_Command();

            Assert.AreEqual(look.Execute(me, new string[] { "look", "at", "inventory" }), me.FullDescription);
        }
        [Test()]

        public void TestLookAtGem()
        {
            Player Jason = new Player("Jason", "player 1");
            Jason.Inventory.Put(gems);

            Look_Command look = new Look_Command();
            //Assert
            Assert.AreEqual(look.Execute(Jason, new string[]{ "look","at","gems" }),gems.FullDescription);
        }

        [Test]
        public void TestLookAtUnk()
        {
            p = new Player("Jason", "player 1");
            c = new Look_Command();

            string expect = "I can't find gem";
            string actual = c.Execute(p, new string[] { "look", "at", "gem" });

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void TestLookAtGemInMe()
        {
            p = new Player("Jason", "player1");
            p.Inventory.Put(gems);
            c = new Look_Command();

            string expect = "precious metal";
            string actual = c.Execute(p, new string[] { "look", "at", "gems", "in", "inventory" });

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void TestLooKatGeminBag()
        {
            p = new Player("Jason", "Player1");
            b = new Bag(new string[] { "small", "pocket", "bag" }, "bag", "small pocket bag");

            //put bags items from setup to player's bag inventory
            b.inventory.Put(gems);
            //put bag items player inventory
            p.Inventory.Put(b);

            c = new Look_Command();

            string expect = "precious metal";
            string actual = c.Execute(p, new string[] { "look", "at", "gems", "in", "bag" });

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void TestLookGeminNoBag()
        {
            p = new Player("Jason", "Player1");
            p.Inventory.Put(gems);

            c = new Look_Command();

            string expect = "I could not find bag.";
            string actual = c.Execute(p, new string[] { "look", "at", "gems", "in", "bag" });

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void TestLookatNoGeminBag()
        {
            p = new Player("Jason", "player");
            b = new Bag(new string[] { "small", "pocket", "bag" }, "bag", "small pocket bag");
            p.Inventory.Put(b);

            c = new Look_Command();

            string expect = "I can't find gems";
            string actual = c.Execute(p, new string[] { "look", "at", "gems", "in", "inventory" });

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void TestInvalidLook()
        {
            p = new Player("Jason", "player");
            c = new Look_Command();

            string expect = "What do you want to look at?";
            string actual = c.Execute(p, new string[] {"look","around","food","in","game"});

            Assert.AreEqual(expect, actual);


        }

    }
}