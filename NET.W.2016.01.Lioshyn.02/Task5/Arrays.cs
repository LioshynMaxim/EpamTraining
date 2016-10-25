using System;

namespace Task5
{
    public class Arrays
    {
        #region fields
        private static int[] _arr;


        #endregion

        #region .ctor

        
        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="n"> Number of elements in the array</param>

        public Arrays(int n)
        {
            if (n < 0)
            {
                n = 0;
            }

            _arr = new int[n];
        }

        #endregion

        #region GenerateSerialArray



        
        /// <summary>
        /// Generate array from sequence of numbers 1 to n
        /// </summary>

        public void GenerateSerialArray()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = i;
            }
        }

        #endregion

        #region PrintArray

        /// <summary>
        /// Print array 
        /// </summary>

        public void PrintArray()
        {
            foreach (int arr in _arr)
            {
                Console.Write(arr + " ");
            }

            Console.WriteLine();
        }

        #endregion

        #region EqualityLeftAndRight

        /// <summary>
        /// The function of finding that the sum of the left and right side.
        /// </summary>
        /// <returns>Index at which are the left and right part.If such an index is not present, it displays -1</returns>

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
                    return -1;
                }

                if (leftSum == rightSum || index < 0)
                {
                    flag = false;
                }
            }

            
            return --index;
        }
        #endregion
    }
}
