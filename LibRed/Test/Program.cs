using Red;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Red.Red.redOpen();
            Red.Red.redDo("view [text {hello}]");
        }
    }
}
