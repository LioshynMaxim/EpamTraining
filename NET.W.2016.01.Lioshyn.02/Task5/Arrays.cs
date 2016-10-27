using System;

namespace Task5
{
    public class Arrays
    {
        #region fields
        private readonly int[] arr;


        #endregion

        #region .ctor

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="n">number elements in array</param>
        public Arrays(int n)
        {
            this.arr = new int[n];
        }

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="arr">Arrays for solution</param>
        public Arrays(int[] arr)
        {
            this.arr = arr;
        }

        /// <summary>
        /// The class constructor
        /// </summary>
        
        private Arrays()
        {
            throw new NotImplementedException();
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
                    leftSum += arr[i];
                }

                for (int i = ++ index; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }

                if ((index == arr.Length))
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
