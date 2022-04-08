using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTCodeChallenge;

namespace UnitTests
{
  [TestClass]
  public class TestSum
  {
    [TestMethod]
    public void TestSample1()
    {
      var ops = new Operations();
      var result = ops.Sum("123456".ToCharArray(), "123456".ToCharArray());
      
      Assert.AreEqual(result, "777777");
    }

    [TestMethod]
    public void TestEmptyFirst()
    {
      var ops = new Operations();
      var result = ops.Sum(string.Empty.ToCharArray(), "123456".ToCharArray());

      Assert.AreEqual(result, "654321");
    }

    [TestMethod]
    public void TestEmptySecond()
    {
      var ops = new Operations();
      var result = ops.Sum("123456".ToCharArray(), string.Empty.ToCharArray());

      Assert.AreEqual(result, "123456");
    }

    [TestMethod]
    public void TestEmptyBoth()
    {
      var ops = new Operations();
      var result = ops.Sum(string.Empty.ToCharArray(), string.Empty.ToCharArray());

      Assert.AreEqual(result, "0");
    }

    [TestMethod]
    public void TestLongerFirst()
    {
      var ops = new Operations();
      var result = ops.Sum("123456789".ToCharArray(), "123".ToCharArray());

      Console.WriteLine(result);

      Assert.AreEqual(result, "123457110");
    }

    [TestMethod]
    public void TestLongerSecond()
    {
      var ops = new Operations();
      var result = ops.Sum("123".ToCharArray(), "123456789".ToCharArray());

      Console.WriteLine(result);

      Assert.AreEqual(result, "987654444");
    }

    [TestMethod]
    public void TestBigNumbersTest1()
    {
      var ops = new Operations();
      var result = ops.Sum("123456789123456789123456789".ToCharArray(), "123456789".ToCharArray());

      Console.WriteLine(result);

      Assert.AreEqual(result, "123456789123456790111111110");
    }

    [TestMethod]
    public void TestBigNumbersTest2()
    {
      var ops = new Operations();
      var result = ops.Sum("123456789123456789123456789123456789".ToCharArray(), "123456789".ToCharArray());

      Console.WriteLine(result);

      Assert.AreEqual(result, "123456789123456789123456790111111110");
    }

    [TestMethod]
    public void TestBigNumbersTest3()
    {
      var ops = new Operations();
      var result = ops.Sum("123456789123456789123456789123456789".ToCharArray(), "123456789123456789123456789123456789".ToCharArray());

      Console.WriteLine(result);

      Assert.AreEqual(result, "1111111111111111111111111111111111110");
    }
  }
}
