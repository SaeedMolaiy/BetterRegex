using BetterRegex.Common.Helpers;
using BetterRegex.Common.Types;
using BetterRegex.Common.Infrastructure;

namespace BetterRegex.Definition.Patterns.MobileNumber;

internal class EuropeMobileNumbers : IDictionaryInitializer
{
    private readonly IDictionary<Country, string> _mobilePatterns;

    public EuropeMobileNumbers()
    {
        _mobilePatterns = new Dictionary<Country, string>();
    }

    public void AddEuropeMobileNumberPatterns(IDictionary<Country, string> dictionary)
    {
        Initialize();

        dictionary.MergeDictionaries(_mobilePatterns);
    }

    public void Initialize()
    {
        throw new NotImplementedException();
    }
}