namespace BetterRegex.Infrastructure.Interfaces;

public interface IRegexValidator
{
    bool IsValid(string text, string pattern);

    bool IsValid(string text);
}