using BetterRegex.Factories;
using BetterRegex.Infrastructure.Interfaces;
using BetterRegex.Types;
using BetterRegex.Common.Configs;
using BetterRegex.Definition;

namespace BetterRegex.Context;

public static class BetterRegex
{
    private static readonly ValidatorFactory ValidatorFactory;

    static BetterRegex()
    {
        ValidatorFactory = new ValidatorFactory();
    }

    public static CultureManager? CultureManager { get; private set; }

    public static IRegexValidator CreateRegexValidator(RegexValidatorTypes validatorType)
    {
        return ValidatorFactory.GetRegexValidator(validatorType);
    }

    public static void InitializePatterns(CultureConfig cultureConfig)
    {
        CultureManager = new CultureManager(cultureConfig);
    }
}