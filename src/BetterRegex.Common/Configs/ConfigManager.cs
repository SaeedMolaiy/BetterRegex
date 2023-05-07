namespace BetterRegex.Common.Configs;

public class ConfigManager
{
    public bool ShouldIncludeAsiaMobilePatterns { get; private set; }

    public bool ShouldIncludeAmericaMobilePatterns { get; private set; }

    public bool ShouldIncludeAfricaMobilePatterns { get; private set; }

    public bool ShouldIncludeEuropeMobilePatterns { get; private set; }

    public ConfigManager IncludeAsiaMobilePatterns()
    {
        ShouldIncludeAsiaMobilePatterns = true;
        return this;
    }

    public ConfigManager IncludeAmericaMobilePatterns()
    {
        ShouldIncludeAmericaMobilePatterns = true;
        return this;
    }

    public ConfigManager IncludeAfricaMobilePatterns()
    {
        ShouldIncludeAfricaMobilePatterns = true;
        return this;
    }

    public ConfigManager IncludeEuropeMobilePatterns()
    {
        ShouldIncludeEuropeMobilePatterns = true;
        return this;
    }
}