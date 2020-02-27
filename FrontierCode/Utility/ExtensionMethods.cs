using System;
using System.Text.RegularExpressions;

namespace FrontierCode.Utility
{
    public static class ExtensionMethods
    {
        private static Regex regexAlpha = new Regex(@"\D");

        public static string FormatAsPhoneNumber(this string source)
        {
            source = regexAlpha.Replace(source, string.Empty);
            source = source.TrimStart('1');

            if (source.Length == 0)
            { source = string.Empty; }
            else if (source.Length < 3)
            { source = string.Format("({0})", source.Substring(0, source.Length)); }
            else if (source.Length < 7)
            { source = string.Format("({0})-{1}", source.Substring(0, 3), source.Substring(3, source.Length - 3)); }
            else if (source.Length < 11)
            { source = string.Format("({0})-{1}-{2}", source.Substring(0, 3), source.Substring(3, 3), source.Substring(6)); }
            else if (source.Length > 10)
            {
                source = source.Remove(source.Length - 1, 1);
                source = string.Format("({0})-{1}-{2}", source.Substring(0, 3), source.Substring(3, 3), source.Substring(6));
            }
            return source;
        }

    }
}
