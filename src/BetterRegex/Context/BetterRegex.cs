using BetterRegex.Common.Configs;
using BetterRegex.Definition;

namespace BetterRegex.Context;

public static class BetterRegex
{
    static BetterRegex()
    {
    }

    public static CultureManager? CultureManager { get; private set; }

    public static void InitializePatterns(CultureConfig cultureConfig)
    {
        CultureManager = new CultureManager(cultureConfig);
    }
}