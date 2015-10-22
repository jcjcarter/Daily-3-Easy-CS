using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_3_Easy_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Code code = new Code();

            // Dry run.
            Console.WriteLine(code.encode("Dry run."));

            // Suspend the console.
            Console.ReadKey();
        }
    }
}
