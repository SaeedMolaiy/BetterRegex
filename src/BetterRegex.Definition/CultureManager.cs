using BetterRegex.Definition.Patterns;

using BetterRegex.Common.Configs;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition;

public class CultureManager
{
    public IDictionary<Country, string> MobileNumberPatterns;

    private readonly MobileNumberPatternCollection _mobileNumberPatternCollection;

    public CultureManager(CultureConfig cultureConfig)
    {
        _mobileNumberPatternCollection = new MobileNumberPatternCollection(cultureConfig);

        MobileNumberPatterns = new Dictionary<Country, string>();

        InitializeMobileNumberDirectory();
    }

    public string GetMobileNumberPattern(Country country)
    {
        return MobileNumberPatterns.SingleOrDefault(
            x => x.Key == country).Value;
    }

    public class UrlPatterns
    {
        public const string HttpUrlRegex = "^(http|https)://[^\\s/$.?#].[^\\s]*$";
        public const string FtpUrlRegex = "^(ftp)://[^\\s/$.?#].[^\\s]*$";
        public const string FilePathUrlRegex = "^(file)://[^\\s/$.?#].[^\\s]*$";
        public const string EmailUrlRegex = "^(mailto)://[^\\s/$.?#].[^\\s]*$";
        public const string CustomProtocolUrlRegex = "^[a-zA-Z]+://[^\\s/$.?#].[^\\s]*$";
        public const string DomainNameRegex = "^([a-zA-Z0-9]+(-[a-zA-Z0-9]+)*\\.)+[a-zA-Z]{2,}$";
        public const string IpAddressIPv4 = "^\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b$";
        public const string IpAddressIPv6 = "^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";
        public const string UrlWithQueryParamsRegex = "^(http|https)://[^\\s/$.?#].[^\\s]*\\?[^\\s]*$";
        public const string UrlWithFragmentRegex = "^(http|https)://[^\\s/$.?#].[^\\s]*#[^\\s]*$";
    }

    public class SqlPatterns
    {
    }

    public class EmailPatterns
    {
        public const string SimpleEmailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        public const string SubDomainEmailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}\\.[a-zA-Z]{2,}$";
        public const string CaseInsensitiveEmailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        public const string EmailWithDisplayNameRegex = "^\"[\\w\\s]+\" <[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}>$";
        public const string InternationalDomainEmailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}(?:\\.[a-zA-Z]{2,})?$";
        public const string CountryCodeTldEmailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2}$";
        public const string ThreeLetterCountryCodeTldEmailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{3}$";
        public const string IpAddressDomainEmailRegex = "^[a-zA-Z0-9._%+-]+@[0-9]+(\\.[0-9]+){3}$";
    }

    public class HtmlPatterns
    {
    }

    private void InitializeMobileNumberDirectory()
        => MobileNumberPatterns = _mobileNumberPatternCollection.GetMobileNumberPatterns();
}