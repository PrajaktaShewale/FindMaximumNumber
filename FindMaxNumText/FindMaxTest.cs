using FindMaxNumber;
using NUnit.Framework;

namespace FindMaxNumText
{
    public class Tests
    {
        FindMaxNum maxNum = new FindMaxNum();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA - Arrange, Act, Assert
            float result = maxNum.FindMaxInteger(6.8f, 6.2f, 6.3f);
            Assert.AreEqual(6.8f, result);
        }

        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = maxNum.FindMaxInteger(6.2f, 6.8f, 6.3f);
            Assert.AreEqual(6.8f, result);

        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = maxNum.FindMaxInteger(6.2f, 6.3f, 6.8f);
            Assert.AreEqual(6.8f, result);

        }
    }
}