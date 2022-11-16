using FindMaxNumber;
using NUnit.Framework;
using System;

namespace FindMaxNumText
{
    public class Tests
    {
        FindMaxNum maxNum = new FindMaxNum();
        FindMaxGeneric generic = new FindMaxGeneric();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA - Arrange, Act, Assert
            int result = generic.FindMax(15, 5, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = generic.FindMax(5, 15, 10);
            Assert.AreEqual(15, result);

        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = generic.FindMax(5, 15, 10);
            Assert.AreEqual(15, result);

        }
        [Test]
        public void GivenMaxFirstNumFloatWhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA - Arrange, Act, Assert
            float result = generic.FindMax(6.8f, 6.2f, 6.3f);
        Assert.AreEqual(6.8f, result);
        }

    [Test]
    public void GivenMaxSecondNumFloatWhenAnalysed_ShouldReturnSecondMax()
    {
        float result = generic.FindMax(6.2f, 6.8f, 6.3f);
        Assert.AreEqual(6.8f, result);

    }
    [Test]
    public void GivenMaxThirdNumFloatWhenAnalysed_ShouldReturnThirdMax()
    {
        float result = generic.FindMax(6.2f, 6.3f, 6.8f);
        Assert.AreEqual(6.8f, result);

    }
        [Test]
        public void GivenMaxFirstNumStringWhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA - Arrange, Act, Assert
            string result = generic.FindMax("Peach", "Apple", "Banana");
    Assert.AreEqual("Peach", result);
        }
[Test]
public void GivenMaxSecondNumStringWhenAnalysed_ShouldReturnSecondMax()
{
    string result = generic.FindMax("Banana", "Peach", "Apple");
    Assert.AreEqual("Peach", result);
}
[Test]
public void GivenMaxThirdNumStringWhenAnalysed_ShouldReturnThirdMax()
{
    string result = generic.FindMax("Apple", "Banana", "Peach");
    Assert.AreEqual("Peach", result);

}
}
}