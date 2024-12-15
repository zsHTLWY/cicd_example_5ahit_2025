using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cicd_example_lib;

namespace cicd_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            Console.WriteLine(e.getInfo());
            Console.ReadKey();
        }
    }
}
