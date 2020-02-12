using System.Collections.Generic;

namespace Features
{
    public static class MyLinq
    {
        /// <summary>
        /// Converts a valid string that contains a double to data of type Double
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static double ToDouble(this string data)
        {
            double result = double.Parse(data);

            return result;
        }
        /// <summary>
        /// Returns the number of elements in an IEnumerator
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;

            foreach (var item in sequence)
            {
                count++;
            }

            return count;
        }
    }
}