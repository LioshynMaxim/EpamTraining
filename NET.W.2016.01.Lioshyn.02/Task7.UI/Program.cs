using System;
using System.Collections;
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
            InsertBinary insertBinary0 = new InsertBinary(8, 15, 0, 0);
            InsertBinary insertBinary1 = new InsertBinary(0, 15, 30, 30);
            InsertBinary insertBinary2 = new InsertBinary(0, 15, 0, 30);
            InsertBinary insertBinary3 = new InsertBinary(15, -15, 4, 4);
            InsertBinary insertBinary4 = new InsertBinary(15, int.MaxValue, 3, 5);
            insertBinary0.Insertion();
            insertBinary1.Insertion();
            insertBinary2.Insertion();
            insertBinary3.Insertion();
            insertBinary4.Insertion();

            Console.ReadKey();
        }

    }
}
