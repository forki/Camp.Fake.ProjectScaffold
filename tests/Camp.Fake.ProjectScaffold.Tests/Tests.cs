using NUnit.Framework;

namespace Camp.Fake.ProjectScaffold.Tests
{
    public class Tests
    {
        [Test]
        public void When_I_say_hello_I_get_42()
        {
            // Arrange.
            // Act.
            var result = Library.hello(42);

            // Assert.
            Assert.AreEqual(42, result);
        }
    }
}