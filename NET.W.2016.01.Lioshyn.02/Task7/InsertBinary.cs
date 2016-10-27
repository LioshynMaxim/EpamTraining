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

        #region fields

        private BitArray firstNumberBitArray;
        private BitArray secondNumberBitArray;
        private int i;
        private int j;

        #endregion

        #region .ctor

        /// <summary>
        /// Ctors Insert Binary
        /// </summary>
        /// <param name="first">First integer number</param>
        /// <param name="second">Second integer number</param>
        /// <param name="i">Index i-th position</param>
        /// <param name="j">Index j-th position</param>

        public InsertBinary(int? first, int? second, int? i, int? j)
        {
            if ((first == null) || (second == null) || (i == null) || (j == null) )
            {
                
            }
            firstNumberBitArray = ToBinary((int) first);
            secondNumberBitArray = ToBinary((int) second);
            this.i = (int) i;
            this.j = (int) j;
        }

        #endregion

        #region Insertion

        /// <summary>
        /// Function returned integer decimal answer
        /// </summary>
        /// <returns>Decimal answer</returns>

        public long Insertion()
        {
            for (int index1 = this.i, index2 = 0; index1 <= this.j; index1++, index2++)
            {
                firstNumberBitArray[index1] = secondNumberBitArray[index2];
            }

            return ToNumeral(firstNumberBitArray);
        }

        #endregion

        #region Console function

        private void PrintBitArray(BitArray bitArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var b in bitArray)
            {
                sb.Append((bool)b ? "1" : "0");
            }
            Console.Write(sb.ToString());
        }

        #endregion

        #region ToBinary

        /// <summary>
        /// Translations into bits from integer
        /// </summary>
        /// <param name="numeral">Integer numtral</param>
        /// <returns>Bit array</returns>

        private BitArray ToBinary(int numeral)
        {
            return new BitArray(new[] { numeral });
        }

        #endregion

        #region ToNumeral

        /// <summary>
        /// Translations into integer from bits
        /// </summary>
        /// <param name="binary">Binary array</param>
        /// <returns>Numeral</returns>

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

        #endregion

        
    }
}
