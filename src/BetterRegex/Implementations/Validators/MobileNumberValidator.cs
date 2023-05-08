using BetterRegex.Infrastructure.Base;
using BetterRegex.Infrastructure.Interfaces;

namespace BetterRegex.Implementations.Validators;

internal class MobileNumberValidator : RegexValidator, IRegexValidator
{
    public bool IsValid(string text, string pattern)
    {
        throw new NotImplementedException();
    }

    public bool IsValid(string text)
    {
        throw new NotImplementedException();
    }
}