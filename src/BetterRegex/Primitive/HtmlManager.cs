using System.Text.RegularExpressions;

namespace BetterRegex.Primitive;

public class HtmlManager
{
    internal HtmlManager()
    {
    }

    public bool IsValidHtmlTag(string htmlTag)
    {
        string pattern = @"^<.+>$";
        return Regex.IsMatch(htmlTag, pattern);
    }
}