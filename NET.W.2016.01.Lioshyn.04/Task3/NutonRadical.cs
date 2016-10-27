using System;

namespace Task3
{
    public class NutonRadical
    {

        #region fields

        private readonly double number;
        private readonly double pow;
        private readonly int round;

        private readonly double eps;


        #endregion

        #region .ctors

        /// <summary>
        /// Ctors method for solve radical method
        /// </summary>
        /// <param name="number">The number from which the root is removed</param>
        /// <param name="pow">Root level</param>
        /// <param name="round">The number of decimal places</param>
        public NutonRadical(double number, double pow, int? round)
        {
            if (Double.IsNaN(number) || (Double.IsNaN(pow)) || (round != null))
            {
                throw new ArgumentException();
            }
            this.round = (int) round;
            this.eps = Math.Pow(10, (int) -round);
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
        
        /// <returns>Radical of A</returns>

        private double RadicalN(double n, double A)
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

        #region Radical
        /// <summary>
        /// Return Radical Fuction
        /// </summary>
        /// <returns>Answer</returns>

        public double Radical()
        {

            return Math.Round(RadicalN(pow, number),round);
        }


        #endregion
    }
}
