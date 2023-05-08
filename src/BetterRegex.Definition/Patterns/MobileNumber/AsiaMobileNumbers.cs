using BetterRegex.Common.Helpers;

namespace BetterRegex.Definition.Patterns.MobileNumber;

using BetterRegex.Common.Types;

internal class AsiaMobileNumbers
{
    private readonly IDictionary<Country, string> _mobilePatterns;

    public AsiaMobileNumbers()
    {
        _mobilePatterns = new Dictionary<Country, string>();
    }

    public void AddAsiaMobileNumberPatterns(IDictionary<Country, string> dictionary)
    {
        dictionary.MergeDictionaries(_mobilePatterns);
    }
}