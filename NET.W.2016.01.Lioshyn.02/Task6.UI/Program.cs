using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6;

namespace Task6.UI
{
    class Program
    {
        static void Main(string[] args)
        {


            string str1 = "", str2 = "";
            Console.WriteLine("Write 2 line");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            //str1 = "xyaabbbccccdefww";
            //str2 = "xxxxyyyyabklmopq";

            //str1 = "abcdefghijklmnopqrstuvwxyz";
            //str2 = str1;

            ConCatSortClass conCatSortClass = new ConCatSortClass(str1, str2);
            conCatSortClass.Longest();

            Console.ReadKey();
        }
    }
}
