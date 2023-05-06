using BetterRegex.Factories;
using BetterRegex.Infrastructure.Interfaces;
using BetterRegex.Types;

namespace BetterRegex.Context
{
    public static class BetterRegex
    {
        private static readonly ValidatorFactory ValidatorFactory;

        static BetterRegex()
        {
            ValidatorFactory = new ValidatorFactory();
        }

        public static IRegexValidator CreateRegexValidator(RegexValidatorTypes validatorType)
        {
            return ValidatorFactory.GetRegexValidator(validatorType);
        }
    }
}