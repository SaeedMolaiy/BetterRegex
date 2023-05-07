using BetterRegex.Factories;
using BetterRegex.Infrastructure.Interfaces;
using BetterRegex.Types;
using BetterRegex.Common.Configs;

namespace BetterRegex.Context;

public static class BetterRegex
{
    public static readonly ConfigManager Configs;

    private static readonly ValidatorFactory ValidatorFactory;

    static BetterRegex()
    {
        Configs = new ConfigManager();
        ValidatorFactory = new ValidatorFactory();
    }

    public static IRegexValidator CreateRegexValidator(RegexValidatorTypes validatorType)
    {
        return ValidatorFactory.GetRegexValidator(validatorType);
    }
}