using BetterRegex.Common.Helpers;

namespace BetterRegex.Definition.Patterns.MobileNumber;

using BetterRegex.Common.Types;

internal class AmericaMobileNumbers
{
    private readonly IDictionary<Country, string> _mobilePatterns;

    public AmericaMobileNumbers()
    {
        _mobilePatterns = new Dictionary<Country, string>();
    }

    public void AddAmericaMobileNumberPatterns(IDictionary<Country, string> dictionary)
    {
        dictionary.MergeDictionaries(_mobilePatterns);
    }
}