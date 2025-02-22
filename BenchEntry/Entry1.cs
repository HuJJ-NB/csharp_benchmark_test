namespace bench;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void TestAddition()
    {
        var result = AddMulTest.Add(4, 5);
        Assert.That(result, Is.EqualTo(9));
    }
    [Test]
    public void TestMul()
    {
        var result = AddMulTest.Mul(4, 5);
        Assert.That(result, Is.EqualTo(20));
    }
}
