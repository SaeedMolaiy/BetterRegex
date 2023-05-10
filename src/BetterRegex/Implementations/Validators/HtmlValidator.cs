using System.Text.RegularExpressions;

using BetterRegex.Infrastructure.Base;
using BetterRegex.Infrastructure.Interfaces;

namespace BetterRegex.Implementations.Validators;

internal class HtmlValidator : RegexValidator, IRegexValidator
{
    public bool IsValid(string text, string pattern)
    {
        var regex = new Regex(pattern);

        return regex.IsMatch(text);
    }

    public bool IsValid(string text)
    {
        var regex = new Regex(DefaultHtmlPattern);

        return regex.IsMatch(text);
    }
}