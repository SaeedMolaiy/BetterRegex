using BetterRegex.Definition.Patterns;

using BetterRegex.Common.Configs;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition;

public class CultureManager
{
    public IDictionary<Country, string> MobileNumberPatterns;

    private readonly MobileNumberPatternCollection _mobileNumberPatternCollection;

    public CultureManager(CultureConfig cultureConfig)
    {
        _mobileNumberPatternCollection = new MobileNumberPatternCollection(cultureConfig);

        MobileNumberPatterns = new Dictionary<Country, string>();

        InitializeMobileNumberDirectory();
    }

    public string GetMobileNumberPattern(Country country)
    {
        return MobileNumberPatterns.SingleOrDefault(
            x => x.Key == country).Value;
    }

    public class UrlPatterns
    {
    }

    public class SqlPatterns
    {
    }

    public class EmailPatterns
    {
    }

    public class HtmlPatterns
    {
    }

    private void InitializeMobileNumberDirectory()
        => MobileNumberPatterns = _mobileNumberPatternCollection.GetMobileNumberPatterns();
}