using NUnit.Framework;

namespace Autotests.Tests
{
    public class Test1
    {
        [Test]
        public void HelloWorldTest()
        {
            Assert.That("Hello world".Length, Is.EqualTo(11));
        }
    }
}
