using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class NutonRadical
    {

        #region fields

        private readonly double number;
        private readonly int pow;

        #endregion

        #region .ctors

        /// <summary>
        /// Ctors method for solve radical method
        /// </summary>
        /// <param name="number"></param>
        /// <param name="pow"></param>
        public NutonRadical(double number, int pow)
        {
            this.pow = pow;
            this.number = number;
        }

        #endregion

        #region RadicalN

        /// <summary>
        /// The basic method of calculating the root of n-th degree of Newton's method.
        /// </summary>
        /// <param name="n">Power degree</param>
        /// <param name="A">The number from which the root is removed</param>
        /// <param name="eps">Accuracy</param>
        /// <returns>Radical of A</returns>

        private double RadicalN(double n, double A, double eps)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n-1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));
            }


            return x1;
        }

        #endregion

        #region Return
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public double Radical()
        {
            return RadicalN(pow, number, 0.001);
        }


        #endregion
    }
}
