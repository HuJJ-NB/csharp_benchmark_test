using NUnit.Framework;
using System.Reflection;

public class Tests
{
    public int Mul(int a, int b)
    {
        return a * b;
    }

    public static int add(int a, int b)
    {
        return a + b;
    }
}

namespace MyTestProject
{
    [TestFixture]
    public class Tests2
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestAddition()
        {
            var result1 = Tests.Mul(4, 5);
            Assert.AreEqual(20, result1);
            var result2 = Tests.Add(4, 5);
            Assert.AreEqual(9, result2);
        }
    }
}
