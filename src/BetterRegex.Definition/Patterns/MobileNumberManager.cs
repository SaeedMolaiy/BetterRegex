using BetterRegex.Definition.Types;

using BetterRegex.Common.Configs;

namespace BetterRegex.Definition.Patterns
{
    internal class MobileNumberManager
    {
        private readonly ConfigManager _configManager;
        private readonly IDictionary<Countries, string> _mobileNumberPatterns;

        public MobileNumberManager(ConfigManager configManager)
        {
            _mobileNumberPatterns = new Dictionary<Countries, string>();

            _configManager = configManager;
        }

        public IDictionary<Countries, string> GetMobileNumberPatterns()
        {
            InitializeDictionary();

            return _mobileNumberPatterns;
        }

        private void InitializeDictionary()
        {
            //TODO
        }
    }
}