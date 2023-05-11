using BetterRegex.Common.Configs;
using BetterRegex.Definition;

namespace BetterRegex.Context;

public static class BetterRegex
{
    static BetterRegex()
    {
    }

    public static RegexCollection? RegexCollection { get; private set; }

    public static void InitializePatterns(RegexCollectionConfig regexCollectionConfig)
    {
        RegexCollection = new RegexCollection(regexCollectionConfig);
    }
}