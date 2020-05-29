using NUnit.Framework;

namespace _1_TwoSum
{
    public class TwoSumTest
    {
        [Test]
        public void Test1()
        {
            var res = new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            var expected = new int[] { 0, 1 };
            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}
