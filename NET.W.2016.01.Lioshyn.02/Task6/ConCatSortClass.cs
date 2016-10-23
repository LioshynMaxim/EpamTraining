using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Longest()
        {
            _finishStr = ConCatDeleteDuplicate();
            _finishStr = string.Concat(_finishStr.OrderBy(x => x).ToArray());
            Console.WriteLine(_finishStr);
        }
    }
}
