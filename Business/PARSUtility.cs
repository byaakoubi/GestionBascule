using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBascule.Business
{
    class PARSUtility
    {
        /// <summary>
        /// PARSER INTEGER
        /// </summary>
        /// <param name="input_string"></param>
        /// <returns></returns>
        public static int INTEGER_PARSER(string input_string)
        {
            try
            {
                return int.Parse(input_string);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// PARSER REAL
        /// </summary>
        /// <param name="input_string"></param>
        /// <returns></returns>

        public static double REAL_PARSER(string input_string)
        {
            try
            {
                return double.Parse(input_string);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// PARSER INTEGER
        /// </summary>
        /// <param name="input_string"></param>
        /// <returns></returns>

        public static DateTime DATETIME_PARSER(string input_string)
        {
            try
            {
                return DateTime.Parse(input_string);
            }
            catch
            {
                return DateTime.Parse("01/01/2000 00:00:00");
            }
        }


    }
}
