using System.Collections.ObjectModel;

using BetterRegex.Definition.Patterns;

using BetterRegex.Common.Configs;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition;

public class RegexCollection
{
    public IReadOnlyDictionary<Country, string> MobileNumberPatterns = null!;

    private readonly MobileNumberPatternCollection _mobileNumberPatternCollection;

    public RegexCollection(RegexCollectionConfig regexCollectionConfig)
    {
        _mobileNumberPatternCollection = new MobileNumberPatternCollection(regexCollectionConfig);

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
        public const string SqlCommentRegex = "--.*$";
        public const string SqlStringLiteralRegex = "'[^']*'";
        public const string SqlIdentifierRegex = "\b[a-zA-Z_][a-zA-Z0-9_]*\b";
        public const string SqlNumberRegex = "\\b[+-]?\\d+(\\.\\d+)?\\b";

        public const string SqlKeywordRegex = "\b(SELECT|FROM|WHERE|JOIN|GROUP BY|ORDER BY|INSERT INTO|VALUES|UPDATE|SET|DELETE " +
                                              "FROM|CREATE TABLE|ALTER TABLE|DROP TABLE|AND|OR|NOT|IN|LIKE)\b";

        public const string SqlOperatorRegex = "[\\+\\-\\*/=<>]";
        public const string SqlFunctionRegex = "\b(COUNT|SUM|AVG|MAX|MIN|DATEPART|DATEDIFF|GETDATE|NOW)\b";
        public const string SqlStatementRegex = "\b(SELECT|INSERT INTO|UPDATE|DELETE FROM|CREATE TABLE|ALTER TABLE|DROP TABLE)\b";
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
        public const string HtmlTagRegex = "<([a-zA-Z][a-zA-Z0-9]*)\\b[^>]*>.*?</\\1>";
        public const string HtmlAttributeRegex = "(?<=\\s|^)(\\w+)(?==['\"]?(([^'\"\\s]+)|(['\"])([^'\"]+)\\4))(?=\\s|$)";
        public const string HtmlCommentRegex = "<!--(.*?)-->";
        public const string HtmlEntityRegex = "&[a-zA-Z][a-zA-Z0-9]*;";
        public const string HtmlLinkRegex = "<a\\b[^>]+href=['\"](.*?)['\"][^>]*>.*?</a>";
        public const string HtmlImageRegex = "<img\\b[^>]+src=['\"](.*?)['\"][^>]*>";
        public const string HtmlStyleRegex = "<style\b[^>]*>(.*?)</style>";
        public const string HtmlHeadingRegex = "<h[1-6]\b[^>]*>.*?</h[1-6]>";
        public const string HtmlScriptRegex = "<script\b[^>]*>(.*?)</script>";
        public const string HtmlListRegex = "<(ul|ol)\\b[^>]*>.*?</\\1>";
    }

    private void InitializeMobileNumberDirectory()
    {
        var mobilePatterns = _mobileNumberPatternCollection.GetMobileNumberPatterns();

        MobileNumberPatterns = new ReadOnlyDictionary<Country, string>(mobilePatterns);
    }
}