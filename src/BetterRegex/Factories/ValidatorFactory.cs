using BetterRegex.Implementations.Validators;
using BetterRegex.Infrastructure.Interfaces;
using BetterRegex.Types;

namespace BetterRegex.Factories
{
    internal class ValidatorFactory
    {
        public IRegexValidator GetRegexValidator(RegexValidatorTypes regexValidatorType)
        {
            return regexValidatorType switch
            {
                RegexValidatorTypes.MobileNumber => new MobileNumberValidator(),

                RegexValidatorTypes.Email => new EmailValidator(),

                RegexValidatorTypes.Sql => new SqlValidator(),

                RegexValidatorTypes.Html => new HtmlValidator(),

                RegexValidatorTypes.Url => new UrlValidator(),

                _ => throw new ArgumentOutOfRangeException(nameof(regexValidatorType), regexValidatorType, null)
            };
        }
    }
}