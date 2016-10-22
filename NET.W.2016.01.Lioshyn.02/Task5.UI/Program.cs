using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace Task5.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays(5);
            arrays.GenerateSerialArray();
            arrays.PrintArray();

            arrays.TestArray();
            arrays.PrintArray();

            Console.Write(arrays.EqualityLeftAndRight());
            Console.ReadKey();
        }
        
    }
}
