using System.Text.RegularExpressions;

namespace BetterRegex.Helpers
{
    internal static class RegexHelper
    {
        public static Regex GetRegex(string pattern)
        {
            return new Regex(pattern);
        }
    }
}