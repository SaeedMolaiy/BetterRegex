using BetterRegex.Common.Helpers;
using BetterRegex.Common.Infrastructure;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition.Patterns.MobileNumber;

internal class AmericaMobileNumbers : IDictionaryInitializer
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

    public void Initialize()
    {
        throw new NotImplementedException();
    }
}