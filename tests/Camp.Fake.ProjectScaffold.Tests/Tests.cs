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
            var result = Library.Hello(42);

            // Assert.
            Assert.AreEqual(42, result);
        }

        [Test]
        public void When_I_say_hello_with_41_I_also_get_42()
        {
            // Arrange.
            // Act.
            var result = Library.Hello(41);

            // Assert.
            Assert.AreEqual(42, result);
        }
    }
}