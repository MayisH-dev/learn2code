using Xunit;
using FsCheck;

namespace LearnToCode.Assignment.Basics.Tests
{
    public sealed class FirstAssignmentTests
    {
        [Fact]
        public void ReturnsHelloWorld()
        {
            FirstAssignment assignment = new();

            var returned = assignment.HelloProgrammer();

            Assert.Equal("Hello, world", returned);
        }

        [Fact]
        public void PersonalizedGreetingMessage()
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
