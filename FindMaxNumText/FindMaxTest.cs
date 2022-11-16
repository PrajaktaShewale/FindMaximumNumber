using FindMaxNumber;
using NUnit.Framework;
using System;

namespace FindMaxNumText
{
    public class Tests
    {
        FindMaxNum maxNum = new FindMaxNum();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA - Arrange, Act, Assert
            string result = maxNum.FindMax("Apple", "Peach", "Banana");
            Assert.AreEqual("Apple", result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = maxNum.FindMax("Banana", "Apple", "Peach");
            Assert.AreEqual("Apple", result);

        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = maxNum.FindMax("Peach", "Banana", "Apple");
            Assert.AreEqual("Apple", result);

        }
    }
}