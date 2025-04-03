namespace TestSolutionBeech.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        int testValue = 42;
        Assert.AreEqual(testValue, 42);
    }
    [TestMethod]
    public void TestMethod2()
    {
        int testValue = 42;
        Assert.AreNotEqual(testValue, 43);
    }
}