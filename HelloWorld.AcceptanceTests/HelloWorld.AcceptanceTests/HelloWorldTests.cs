using fit;

namespace HelloWorld.AcceptanceTests
{
    public class HelloWorldTests : ColumnFixture
    {
        public string Name;

        public string Message()
        {
            return $"Hello, {Name}";
        }
    }
}
