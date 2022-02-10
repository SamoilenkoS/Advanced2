using ClassLibrary;
using NUnit.Framework;

namespace UnitTests
{
    public class ArrayHelperTests
    {
        [TestCase(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 2, 3, 1 }, new[] { 1, 2, 3 })]
        public void Sort_WhenCalled_ShouldSortArrayAscending(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArrayHelper.Sort(sourceArray);

            CollectionAssert.AreEqual(expectedArray, sourceArray);
        }

        [TestCaseSource("MaxInMatrixCases")]
        public void Max_WhenFilledMatrixPassed_ShouldFindMaxValue
            (int[,] matrix, int expectedResult)
        {
            int actualResult = ArrayHelper.Max(matrix);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MaxInMatrixCases =
        {
            new object[] { new[,] { {1, 2, 3 }, {4, 5, 6 }, {7, 8, 9 } }, 9 },
            new object[] { new[,] {  {4, 10, 6, 6 }, {7, 4, 1, 9 } }, 10}
        };
    }
}
