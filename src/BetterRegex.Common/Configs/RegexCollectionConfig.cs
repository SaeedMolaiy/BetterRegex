namespace BetterRegex.Common.Configs;

public class RegexCollectionConfig
{
    public bool ShouldIncludeAsiaMobilePatterns { get; set; } = false;

    public bool ShouldIncludeAmericaMobilePatterns { get; set; } = false;

    public bool ShouldIncludeAfricaMobilePatterns { get; set; } = false;

    public bool ShouldIncludeEuropeMobilePatterns { get; set; } = false;

    public bool ShouldIncludeOceaniaMobilePatterns { get; set; } = false;
}