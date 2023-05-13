using System.Text.RegularExpressions;

namespace BetterRegex.Primitive;

public class HtmlManager
{
    internal HtmlManager()
    {
    }

    /// <summary>
    ///     Checks if the provided string represents a valid HTML tag.
    /// </summary>
    /// <param name="htmlTag">The HTML tag to validate.</param>
    /// <returns><c>true</c> if the HTML tag is valid; otherwise, <c>false</c>.</returns>
    public bool IsValidHtmlTag(string htmlTag)
    {
        const string pattern = @"^<.+>$";
        return Regex.IsMatch(htmlTag, pattern);
    }
}