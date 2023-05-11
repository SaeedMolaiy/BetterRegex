using BetterRegex.Definition.Patterns.MobileNumber;

using BetterRegex.Common.Configs;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition.Patterns;

internal class MobileNumberPatternCollection
{
    private readonly RegexCollectionConfig _regexCollectionConfig;
    private readonly IDictionary<Country, string> _mobileNumberPatterns;

    public MobileNumberPatternCollection(RegexCollectionConfig regexCollectionConfig)
    {
        _mobileNumberPatterns = new Dictionary<Country, string>();

        _regexCollectionConfig = regexCollectionConfig;
    }

    public IDictionary<Country, string> GetMobileNumberPatterns()
    {
        InitializeDictionary();

        return _mobileNumberPatterns;
    }

    private void InitializeDictionary()
    {
        if (_regexCollectionConfig.ShouldIncludeAfricaMobilePatterns)
        {
            var africaMobileNumberPatterns = new AfricaMobileNumbers();

            africaMobileNumberPatterns.AddAfricaMobileNumberPatterns(_mobileNumberPatterns);
        }

        if (_regexCollectionConfig.ShouldIncludeAmericaMobilePatterns)
        {
            var americaMobileNumberPatterns = new AmericaMobileNumbers();

            americaMobileNumberPatterns.AddAmericaMobileNumberPatterns(_mobileNumberPatterns);
        }

        if (_regexCollectionConfig.ShouldIncludeAsiaMobilePatterns)
        {
            var asiaMobileNumberPatterns = new AsiaMobileNumbers();

            asiaMobileNumberPatterns.AddAsiaMobileNumberPatterns(_mobileNumberPatterns);
        }

        if (!_regexCollectionConfig.ShouldIncludeEuropeMobilePatterns)
        {
            return;
        }

        var europeMobileNumberPatterns = new EuropeMobileNumbers();

        europeMobileNumberPatterns.AddEuropeMobileNumberPatterns(_mobileNumberPatterns);
    }
}