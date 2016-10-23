using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class InsertBinary
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _i;
        private int _j;
        private string _str;

        public InsertBinary(int first, int second, int i, int j)
        {
            _firstNumber = first;
            _secondNumber = second;
            _i = i;
            _j = j;
        }

        private int BinaryToInt(string str)
        {
            return Convert.ToInt32(str, 10);
        }

        private string IntToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        public void Insertion()
        {

        }

        public void PrintNumber()
        {
            string str = IntToBinary(_firstNumber);
            int i = BinaryToInt(str) + 1;
            Console.Write(i.ToString());
        }
    }
}
