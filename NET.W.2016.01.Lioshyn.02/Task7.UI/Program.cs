using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7;

namespace Task7.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertBinary insertBinary = new InsertBinary(8, 15, 0, 0);
            insertBinary.PrintNumber();

            Console.ReadKey();
        }

    }
}
