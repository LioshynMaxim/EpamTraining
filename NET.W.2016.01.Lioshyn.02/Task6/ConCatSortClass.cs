using System;
using System.Diagnostics;
using System.Linq;

namespace Task6
{
    public class ConCatSortClass
    {
        private readonly string _startStr;
        private string _finishStr;

        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="str1">First string.</param>
        /// <param name="str2">Second string.</param>

        public ConCatSortClass(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
            {
                throw new ArgumentException();
            }
            _startStr = str1 + str2;
            _finishStr = "";
        }

        /// <summary>
        /// String concatenation and Delete duplicate chars
        /// </summary>
        /// <returns>line string </returns>
        private string ConCatDeleteDuplicate()
        {
            string str = "";

            for (int i = 97; i <= 122; i++)
            {
                if (_startStr.IndexOf((char)i) > -1)
                {
                    str += (char) i;
                }
            }
            return str;
        }

        /// <summary>
        /// Sort line small laters order by ABC and show it.
        /// </summary>
        /// <returns> Finish string</returns>

        public string Longest()
        {
            _finishStr = ConCatDeleteDuplicate();
            _finishStr = string.Concat(_finishStr.OrderBy(x => x).ToArray());
            return _finishStr;
        }
    }
}
