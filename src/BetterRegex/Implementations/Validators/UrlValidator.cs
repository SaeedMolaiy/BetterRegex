using System.Text.RegularExpressions;

using BetterRegex.Infrastructure.Base;
using BetterRegex.Infrastructure.Interfaces;

namespace BetterRegex.Implementations.Validators;

internal class UrlValidator : RegexValidator, IRegexValidator
{
    public bool IsValid(string text, string pattern)
    {
        var regex = new Regex(pattern);

        return regex.IsMatch(text);
    }

    public bool IsValid(string text)
    {
        var regex = new Regex(DefaultUrlPattern);

        return regex.IsMatch(text);
    }
}