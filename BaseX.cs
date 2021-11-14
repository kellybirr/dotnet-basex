using System;
using System.Collections.Generic;
using System.Linq;

namespace Kelly.Codes.Samples
{
    public static class BaseX
    {
        public static string Encode(long input, string charset)
        {
            long b = charset.Length;

            if (input < 0)
                throw new ArgumentOutOfRangeException(nameof(input), input, "input cannot be negative");

            var result = new Stack<char>();
            while (input != 0)
            {
                result.Push(charset[(int)(input % b)]);
                input /= b;
            }
            return new string(result.ToArray());
        }

        public static long Decode(string input, string charset)
        {
            long b = charset.Length, p = 0;
            return input.Reverse().Sum(
                c => charset.IndexOf(c) * (long)Math.Pow(b, p++)
                );
        }
    }

    public static class Base36
    {
        private const string _charset = "0123456789abcdefghijklmnopqrstuvwxyz";
        public static string Encode(long input) => BaseX.Encode(input, _charset);
        public static long Decode(string input) => BaseX.Decode(input.ToLower(), _charset);
    }

    public static class Base62
    {
        private const string _charset = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Encode(long input) => BaseX.Encode(input, _charset);
        public static long Decode(string input) => BaseX.Decode(input, _charset);
    }
}
