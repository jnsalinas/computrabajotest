using System;
namespace ComputrabajoTest.Utilities.Helper.String
{
	public static class HelperString
	{
        /// <summary>
        /// truncate string for insert faker data 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static string TruncateString(this string value, int maxLength)
        {
            return value.Substring(0, Math.Min(value.Length, maxLength));
        }
    }
}

