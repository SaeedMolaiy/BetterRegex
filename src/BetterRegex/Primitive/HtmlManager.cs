using System.Text.RegularExpressions;

using BetterRegex.Models;

namespace BetterRegex.Primitive;

public class HtmlManager
{
    private static readonly Lazy<HtmlManager> LazyInstance =
            new(() => new HtmlManager(), LazyThreadSafetyMode.ExecutionAndPublication);

    private HtmlManager()
    {
    }

    public static HtmlManager Instance => LazyInstance.Value;

    /// <summary>
    ///     Retrieves all HTML elements from the provided HTML string.
    /// </summary>
    /// <param name="html">The HTML string to extract elements from.</param>
    /// <returns>A list of HTML element names.</returns>
    public IEnumerable<string> GetElements(string html)
    {
        var elements = new List<string>();

        const string pattern = @"<(\w+).*?>";

        foreach (Match match in Regex.Matches(html, pattern))
        {
            elements.Add(match.Groups[1].Value);
        }

        return elements;
    }

    /// <summary>
    ///     Retrieves HTML elements with additional information from the provided HTML string.
    /// </summary>
    /// <param name="html">The HTML string to extract elements from.</param>
    /// <returns>A list of <see cref="ElementInfo"/> containing element information.</returns>
    public static IEnumerable<ElementInfo> GetElementsWithInfo(string html)
    {
        var elements = new List<ElementInfo>();

        const string pattern = @"<(\w+)(.*?)>";

        foreach (Match match in Regex.Matches(html, pattern))
        {
            var tagName = match.Groups[1].Value;
            var attributesText = match.Groups[2].Value;

            var elementInfo = new ElementInfo
            {
                TagName = tagName,
                Attributes = new Dictionary<string, string>()!,
                Styles = new Dictionary<string, string>()
            };

            FillElementInfo(attributesText, elementInfo);

            elements.Add(elementInfo);
        }

        return elements;
    }

    /// <summary>
    ///     Checks if the input string contains a script tag or JavaScript code.
    /// </summary>
    /// <param name="input">The string to be validated.</param>
    /// <returns>True if the string contains a script tag or JavaScript code; otherwise, false.</returns>
    public bool ContainsScript(string input)
    {
        const string pattern = @"<script\b[^<]*(?:(?!<\/script>)<[^<]*)*<\/script>";

        return Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase);
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

    private static void FillElementInfo(string attributesText, ElementInfo elementInfo)
    {
        const string attributePattern = @"(\w+)\s*=\s*""(.*?)""";
        const string stylePattern = @"\b(\w+)\s*:\s*([^;]+);?";

        foreach (Match match in Regex.Matches(attributesText, attributePattern))
        {
            var attributeName = match.Groups[1].Value;
            var attributeValue = match.Groups[2].Value;

            switch (attributeName.ToLower())
            {
                case "id":
                    elementInfo.Id = attributeValue;
                    break;

                case "value":
                    elementInfo.Value = attributeValue;
                    break;

                case "placeholder":
                    elementInfo.Placeholder = attributeValue;
                    break;

                default:
                    if (elementInfo.Attributes != null)
                    {
                        elementInfo.Attributes[attributeName] = attributeValue;
                    }
                    break;
            }
        }

        foreach (Match match in Regex.Matches(attributesText, stylePattern))
        {
            var styleName = match.Groups[1].Value;
            var styleValue = match.Groups[2].Value;

            if (elementInfo.Styles != null)
            {
                elementInfo.Styles[styleName] = styleValue;
            }
        }
    }
}