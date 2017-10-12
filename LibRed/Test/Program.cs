using LibRed;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Red.OpenRuntime();
            Red.Do("view [text {hello}]");
        }
    }
}
