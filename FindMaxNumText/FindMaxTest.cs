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
            string result = maxNum.FindMax("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = maxNum.FindMax("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", result);

        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = maxNum.FindMax("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);

        }
    }
}
