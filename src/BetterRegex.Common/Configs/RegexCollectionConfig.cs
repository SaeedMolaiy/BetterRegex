namespace BetterRegex.Common.Configs;

public class RegexCollectionConfig
{
    public bool ShouldIncludeAsiaMobilePatterns { get; private set; }

    public bool ShouldIncludeAmericaMobilePatterns { get; private set; }

    public bool ShouldIncludeAfricaMobilePatterns { get; private set; }

    public bool ShouldIncludeEuropeMobilePatterns { get; private set; }

    public RegexCollectionConfig IncludeAsiaMobilePatterns()
    {
        ShouldIncludeAsiaMobilePatterns = true;
        return this;
    }

    public RegexCollectionConfig IncludeAmericaMobilePatterns()
    {
        ShouldIncludeAmericaMobilePatterns = true;
        return this;
    }

    public RegexCollectionConfig IncludeAfricaMobilePatterns()
    {
        ShouldIncludeAfricaMobilePatterns = true;
        return this;
    }

    public RegexCollectionConfig IncludeEuropeMobilePatterns()
    {
        ShouldIncludeEuropeMobilePatterns = true;
        return this;
    }
}