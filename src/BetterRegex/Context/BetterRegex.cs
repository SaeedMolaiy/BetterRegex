using BetterRegex.Common.Configs;
using BetterRegex.Definition;
using BetterRegex.Primitive;

namespace BetterRegex.Context;

public static class BetterRegex
{
    static BetterRegex()
    {
    }

    public static RegexCollection? RegexCollection { get; private set; }

    public static HtmlManager Html => HtmlManager.Instance;

    public static SqlManager Sql => SqlManager.Instance;

    public static void InitializePatterns(RegexCollectionConfig regexCollectionConfig)
    {
        RegexCollection = new RegexCollection(regexCollectionConfig);
    }
}