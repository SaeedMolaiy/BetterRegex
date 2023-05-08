using BetterRegex.Common.Helpers;

namespace BetterRegex.Definition.Patterns.MobileNumber;

using BetterRegex.Common.Types;

internal class AfricaMobileNumbers
{
    private readonly IDictionary<Country, string> _mobilePatterns;

    public AfricaMobileNumbers()
    {
        _mobilePatterns = new Dictionary<Country, string>();
    }

    public void AddAfricaMobileNumberPatterns(IDictionary<Country, string> dictionary)
    {
        dictionary.MergeDictionaries(_mobilePatterns);
    }
}