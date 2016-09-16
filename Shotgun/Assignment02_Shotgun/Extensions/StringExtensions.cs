using System;

namespace Assignment02_Shotgun.Extensions
{
    public static class StringExtensions
    {
        public static string ReplaceLastChar(this string input, string replacer)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("string is empty");
            }
            
            return input.Remove(input.Length - replacer.Length) + replacer; 
        }

        public static string ReplaceLastChar(this string input, int replacer)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("string is empty");
            }

            return input.Remove(input.Length - replacer.ToString().Length) + replacer;
        }
    }
}
