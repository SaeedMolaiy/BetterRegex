using BetterRegex.Infrastructure.Interfaces;
using BetterRegex.Types;

namespace BetterRegex.Factories
{
    internal class ValidatorFactory
    {
        public IRegexValidator GetRegexValidator(RegexValidatorTypes regexValidatorType)
        {
            switch (regexValidatorType)
            {
                case RegexValidatorTypes.PhoneNumber:
                    break;

                case RegexValidatorTypes.Email:
                    break;

                case RegexValidatorTypes.Sql:
                    break;

                case RegexValidatorTypes.Html:
                    break;

                case RegexValidatorTypes.Url:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(regexValidatorType), regexValidatorType, null);
            }

            return null!;
        }
    }
}