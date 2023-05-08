using BetterRegex.Common.Helpers;

namespace BetterRegex.Definition.Patterns.MobileNumber;

using BetterRegex.Common.Types;

internal class EuropeMobileNumbers
{
    private readonly IDictionary<Country, string> _mobilePatterns;

    public EuropeMobileNumbers()
    {
        _mobilePatterns = new Dictionary<Country, string>();
    }

    public void AddEuropeMobileNumberPatterns(IDictionary<Country, string> dictionary)
    {
        dictionary.MergeDictionaries(_mobilePatterns);
    }
}