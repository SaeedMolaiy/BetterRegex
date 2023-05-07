namespace BetterRegex.Common.Configs;

public class CultureConfig
{
    public bool ShouldIncludeAsiaMobilePatterns { get; private set; }

    public bool ShouldIncludeAmericaMobilePatterns { get; private set; }

    public bool ShouldIncludeAfricaMobilePatterns { get; private set; }

    public bool ShouldIncludeEuropeMobilePatterns { get; private set; }

    public CultureConfig IncludeAsiaMobilePatterns()
    {
        ShouldIncludeAsiaMobilePatterns = true;
        return this;
    }

    public CultureConfig IncludeAmericaMobilePatterns()
    {
        ShouldIncludeAmericaMobilePatterns = true;
        return this;
    }

    public CultureConfig IncludeAfricaMobilePatterns()
    {
        ShouldIncludeAfricaMobilePatterns = true;
        return this;
    }

    public CultureConfig IncludeEuropeMobilePatterns()
    {
        ShouldIncludeEuropeMobilePatterns = true;
        return this;
    }
}