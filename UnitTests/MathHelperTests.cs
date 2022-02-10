using ClassLibrary;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class MathHelperTests
    {
        [TestCase(5, 3, 5)]
        [TestCase(1, 10, 10)]
        [TestCase(-5, -3, -3)]
        [TestCase(9, 9, 9)]
        public void Max_WhenAAndBPassed_ShouldFindMaxOfTwoNumbers(
            int a, int b, int expectedResult)
        {
            int actualResult = MathHelper.Max(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(4, 2, 2)]
        [TestCase(5, 2, 2)]
        [TestCase(10, -3, -3)]
        [TestCase(-10, 4, -2)]
        [TestCase(-10, -4, 2)]
        public void GetDivisionResult_WhenBIsNotZero_ShouldCalculateDivision(
            int a, int b, int expectedResult)
        {
            int actualResult = MathHelper.GetDivisionResult(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivisionResult_WhenBIsEqualToZero_ShouldThrowArgumentException()
        {
            try
            {
                MathHelper.GetDivisionResult(5, 0);
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("B is equal to zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}