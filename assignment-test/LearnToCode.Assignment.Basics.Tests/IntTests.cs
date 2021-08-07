using Xunit;
using FsCheck;

namespace LearnToCode.Assignment.Basics.Tests
{
    public sealed class IntTests
    {
        [Fact]
        public void TheKey_ReturnsSixTimesSeven()
        {
            Int assignment = new();

            var returned = assignment.TheKey();

            Assert.Equal(6 * 7, returned);
        }

        [Fact]
        public void Add_ReturnsTheSum()
        {
            Int assignment = new();

            bool SumProperty(int a, int b) =>
                assignment.Add(a, b).Equals(a + b);


            Prop.ForAll<int, int>(SumProperty)
                .QuickCheckThrowOnFailure();
        }
    }
}
