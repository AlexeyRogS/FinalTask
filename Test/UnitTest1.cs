using NUnit.Framework;
using FinalTask;

namespace Test
{
    public class Tests
    {
        [Test]
        public void GivenTests()
        {
            var inputs = new[] {
                new[] { "hello", "2", "world", ":-)" },
                new[] { "1234", "1567", "-2", "computer science" },
                new[] { "Russia", "Denmark", "Kazan"} };
            var ans = new[] { 
                new[] { "2", ":-)" },
                new[] { "-2" },
                new string[0]
            };
            Assert.AreEqual(inputs.Length, ans.Length);
            for (int i=0; i<inputs.Length; i++)
                Assert.AreEqual(ans[i], StringFilter.FilterByLength(inputs[i]));
        }

        [Test]
        public void EmptyInput()
        {
            Assert.AreEqual(new string[0], StringFilter.FilterByLength(new string[0]));
        }

        [Test]
        public void ZeroLength()
        {
            var input = new[] { "abc", "123", "Hello World" };
            Assert.AreEqual(new string[0], StringFilter.FilterByLength(input, 0));
        }

        [Test]
        public void LargeLength()
        {
            var input = new[] { "abc", "123", "Hello World" };
            Assert.AreEqual(input, StringFilter.FilterByLength(input, int.MaxValue));
        }
    }
}