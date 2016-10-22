using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Arrays
    {
        private static int[] _arr;

        public Arrays(int n)
        {
            if (n < 0)
            {
                n = 0;
            }

            _arr = new int[n];
        }

        public void GenerateSerialArray()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = i;
            }
        }

        public void TestArray()
        {
            //_arr = new[] {1, 2, 3, 4, 3, 2, 1};
            _arr = new[] { 1, 100, 50, -51, 1, 1 };
        }

        public void PrintArray()
        {
            foreach (int arr in _arr)
            {
                Console.Write(arr + " ");
            }

            Console.WriteLine();
        }

        public int EqualityLeftAndRight()
        {
            int index = 0;
            bool flag = true;
            while (flag)
            {
                var leftSum = 0;
                var rightSum = 0;
                for (int i = 0; i < index; i++)
                {
                    leftSum += _arr[i];
                }

                for (int i = ++ index; i < _arr.Length; i++)
                {
                    rightSum += _arr[i];
                }

                if ((index == _arr.Length))
                {
                    index = -1;
                }

                if (leftSum == rightSum || index < 0)
                {
                    flag = false;
                }
            }

            
            return --index;
        }
    }
}
