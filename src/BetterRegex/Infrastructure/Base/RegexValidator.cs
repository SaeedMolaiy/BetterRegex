namespace BetterRegex.Infrastructure.Base
{
    internal abstract class RegexValidator
    {
        protected const string DefaultEmailPattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
        protected const string DefaultHtmlPattern = @"^<.+>$";
        protected const string DefaultPhoneNumberPattern = @"^\+\d{10,15}$";
        protected const string DefaultSqlPattern = @"^(SELECT|INSERT|UPDATE|DELETE|EXECUTE)\s.+$";
        protected const string DefaultUrlPattern = @"^(http|https)://[^\s/$.?#].[^\s]*$";
    }
}