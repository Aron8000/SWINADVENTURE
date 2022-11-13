using NUnit.Framework;
using SWINADVENTURE;

namespace IdentiableObjectUnitTest
{
    public class Tests
    {

        IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAreYou()
        {
            bool match = id.AreYou("bob");
            Assert.IsTrue(match, "Are you fred or bob");
        }
        [Test]
        public void TestNotAreYou()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            bool match = id.AreYou("wilma");
            Assert.IsFalse(match, "Cannot be identified");
        }
        [Test]
        public void TestCaseSensitive()
        {
            bool match = id.AreYou("BOB");
            Assert.IsTrue(match, "Sensitive Letter Case Check");
        }
        [Test]
        public void TestFirstID()
        {
            string match = id.FirstId;
            Assert.AreEqual("fred",match,"The firstID name is fred");
        }
        [Test]
        public void TestFirstWithNoID()
        {
            string name = id.FirstId;
            Assert.AreNotEqual(name,"NoID");
        }
        [Test]
        public void TestAddID()
        {
            id.AddIdentifier("wilma");
            Assert.IsTrue(id.AreYou("fred"));
            Assert.IsTrue(id.AreYou("bob"));
            Assert.IsTrue(id.AreYou("wilma"));
        }
    }
}