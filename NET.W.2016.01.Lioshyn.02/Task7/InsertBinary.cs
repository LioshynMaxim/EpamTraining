using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class InsertBinary
    {
        private BitArray firstNumberBitArray;
        private BitArray secondNumberBitArray;
        private int i;
        private int j;

        public InsertBinary(int first, int second, int i, int j)
        {
            firstNumberBitArray = ToBinary(first);
            secondNumberBitArray = ToBinary(second);
            this.i = i;
            this.j = j;
        }

        public void Insertion()
        {
            PrintBitArray(firstNumberBitArray);
            Console.WriteLine();
            PrintBitArray(secondNumberBitArray);
            Console.WriteLine();

            for (int index1 = this.i, index2 = 0; index1 <= this.j; index1++, index2++)
            {
                firstNumberBitArray[index1] = secondNumberBitArray[index2];
            }

            
            PrintBitArray(firstNumberBitArray);
            Console.WriteLine();
            PrintBitArray(secondNumberBitArray);
            Console.WriteLine();

            Console.WriteLine(ToNumeral(firstNumberBitArray));


        }

        public void PrintBitArray(BitArray bitArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var b in bitArray)
            {
                sb.Append((bool)b ? "1" : "0");
            }
            Console.Write(sb.ToString());
        }

        private BitArray ToBinary(int numeral)
        {
            return new BitArray(new[] { numeral });
        }

        private long ToNumeral(BitArray binary)
        {
            if (binary == null)
                throw new ArgumentNullException("binary");
            if (binary.Length > 32)
                throw new ArgumentException("must be at most 32 bits long");

            var result = new int[1];
            binary.CopyTo(result, 0);
            return result[0];
        }
    }
}
