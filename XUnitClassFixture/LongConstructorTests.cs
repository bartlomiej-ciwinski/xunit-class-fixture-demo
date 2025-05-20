namespace XUnitClassFixture
{
    public class LongConstructorTests
    {
        public LongConstructorTests()
        {
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();
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