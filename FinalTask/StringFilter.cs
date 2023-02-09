using System;
using System.Linq;

namespace FinalTask
{
    public static class StringFilter
    {
        /// <summary>
        /// Selects only strings shorter than given length
        /// </summary>
        /// <param name="input"> Array of strings to be filtered</param>
        /// <param name="length"> We will select string with Length less or equal to this parameter</param>
        /// <returns></returns>
        public static string[] FilterByLength(string[] input, int length = 3)
        {
            return input.Where(x => x.Length <= length).ToArray();
        }
    }
}
