using BetterRegex.Common.Configs;
using BetterRegex.Definition;
using BetterRegex.Primitive;

namespace BetterRegex.Context;

public static class BetterRegex
{
    static BetterRegex()
    {
        Html = new HtmlManager();
        Sql = new SqlManager();
    }

    public static RegexCollection? RegexCollection { get; private set; }

    public static HtmlManager Html { get; }

    public static SqlManager Sql { get; }

    public static void InitializePatterns(RegexCollectionConfig regexCollectionConfig)
    {
        RegexCollection = new RegexCollection(regexCollectionConfig);
    }
}