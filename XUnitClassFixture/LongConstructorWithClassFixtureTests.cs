namespace XUnitClassFixture
{
    public class LongConstructorFixture
    {

        public LongConstructorFixture()
        {
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();
        }
    }

    public class LongConstructorWithClassFixtureTests : IClassFixture<LongConstructorFixture>
    {
        public LongConstructorWithClassFixtureTests(LongConstructorFixture fixture)
        {
        }

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {

        }

        [Fact]
        public void Test3()
        {

        }

        [Fact]
        public void Test4()
        {

        }

        [Fact]
        public void Test5()
        {

        }
    }
}