using AXTest;
using NUnit.Framework;

namespace AXTestUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void HelloWorldTest()
        {
            var Target = new AXTest.AXTest();
            var Expected = "Hello, World!";
            var Actual = Target.HelloWorld();

            Assert.AreEqual(Expected, Actual);
        }
    }
}
