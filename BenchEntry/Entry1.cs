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
        var result = TestLib.Add(4, 5);
        Assert.That(result, Is.EqualTo(9));
    }
    [Test]
    public void TestMul()
    {
        var result = TestLib.Mul(4, 5);
        Assert.That(result, Is.EqualTo(20))
    }
}

