using Xunit;
using FsCheck;

namespace LearnToCode.Assignment.Basics.Tests
{
    public sealed class FirstAssignmentTests
    {
        [Fact]
        public void HelloProgrammer_ReturnsHelloWorld()
        {
            FirstAssignment assignment = new();
            const string Expected = "Hello, world";

            var returned = assignment.HelloProgrammer();

            Assert.Equal(Expected, returned);
        }

        [Fact]
        public void GreetMe_AppendsName()
        {
            const string Prefix = "Hello, ";
            FirstAssignment assignment = new();

            bool PersonalizedGreetingAppendsName(string name) =>
                assignment.GreetMe(name).Equals(Prefix + name);

            Prop.ForAll<string>(PersonalizedGreetingAppendsName)
                .QuickCheckThrowOnFailure();
        }
    }
}
