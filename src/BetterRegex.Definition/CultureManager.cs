using BetterRegex.Definition.Patterns.MobileNumber.Base;
using BetterRegex.Definition.Types;

namespace BetterRegex.Definition
{
    public static class CultureManager
    {
        private static readonly IDictionary<string, string> CustomMobileNumberDictionary;
        private static IDictionary<Countries, string> _mobileNumberDictionary;

        static CultureManager()
        {
            _mobileNumberDictionary = new Dictionary<Countries, string>();

            CustomMobileNumberDictionary = new Dictionary<string, string>();

            InitializeMobileNumberDirectory();
        }

        public static void AddCustomMobilePattern(string countryCode, string pattern)
        {
            CustomMobileNumberDictionary.Add(countryCode, pattern);
        }

        public static string GetMobileNumberPattern(Countries countries)
        {
            return _mobileNumberDictionary.SingleOrDefault(
                x => x.Key == countries).Value;
        }

        public static string GetCustomMobileNumberPattern(string countryCode)
        {
            return CustomMobileNumberDictionary.SingleOrDefault(
                x => x.Key == countryCode).Value;
        }

        private static void InitializeMobileNumberDirectory()
        {
            var mobileNumberManager = new MobileNumberManager();

            _mobileNumberDictionary = mobileNumberManager.GetMobileNumberPatterns();
        }
    }
}