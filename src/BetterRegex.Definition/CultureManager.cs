using BetterRegex.Definition.Types;
using BetterRegex.Definition.Patterns;

using BetterRegex.Common.Configs;

namespace BetterRegex.Definition
{
    public class CultureManager
    {
        private readonly IDictionary<string, string> CustomMobileNumberDictionary;
        private readonly MobileNumberManager _mobileNumberManager;

        private IDictionary<Countries, string> _mobileNumberDictionary;

        public CultureManager(ConfigManager configManager)
        {
            CustomMobileNumberDictionary = new Dictionary<string, string>();

            _mobileNumberDictionary = new Dictionary<Countries, string>();
            _mobileNumberManager = new MobileNumberManager(configManager);

            InitializeMobileNumberDirectory();
        }

        public void AddCustomMobilePattern(string countryCode, string pattern)
        {
            CustomMobileNumberDictionary.Add(countryCode, pattern);
        }

        public string GetMobileNumberPattern(Countries countries)
        {
            return _mobileNumberDictionary.SingleOrDefault(
                x => x.Key == countries).Value;
        }

        public string GetCustomMobileNumberPattern(string countryCode)
        {
            return CustomMobileNumberDictionary.SingleOrDefault(
                x => x.Key == countryCode).Value;
        }

        private void InitializeMobileNumberDirectory()
            => _mobileNumberDictionary = _mobileNumberManager.GetMobileNumberPatterns();
    }
}