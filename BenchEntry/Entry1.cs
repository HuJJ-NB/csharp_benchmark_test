namespace benchTmp;

public class TestLib
{
    public static int Mul(int a, int b)
    {
        return a * b;
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}

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
        var result2 = TestLib.Add(4, 5);
        Assert.AreEqual(9, result2);
    }
    [Test]
    public void TestMul()
    {
        var result1 = TestLib.Mul(4, 5);
        Assert.AreEqual(20, result1);
    }
}

