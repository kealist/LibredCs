using LibRed;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Red.OpenRuntime();
            Red.OpenLog("/c/Users/kealist/Documents/test.log");
            Red.Do("view [text {" + Red.HasError() + "}]");
            Red.Print(Red.True);
            Red.CloseLog();
            Red.Do("view [text {" + Red.FormError() + "}]");
        }
    }
}
