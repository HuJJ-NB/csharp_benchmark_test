namespace benchTmp;

using TestForAddMul;

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
        var result = AddMul.Add(4, 5);
        Assert.That(result, Is.EqualTo(9));
    }
    [Test]
    public void TestMul()
    {
        var result = AddMul.Mul(4, 5);
        Assert.That(result, Is.EqualTo(20));
    }
}

