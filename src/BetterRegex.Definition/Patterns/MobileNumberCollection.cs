using BetterRegex.Definition.Types;

using BetterRegex.Common.Configs;
using BetterRegex.Definition.Patterns.MobileNumber;

namespace BetterRegex.Definition.Patterns
{
    internal class MobileNumberCollection
    {
        private readonly CultureConfig _cultureConfig;
        private readonly IDictionary<Country, string> _mobileNumberPatterns;

        public MobileNumberCollection(CultureConfig cultureConfig)
        {
            _mobileNumberPatterns = new Dictionary<Country, string>();

            _cultureConfig = cultureConfig;
        }

        public IDictionary<Country, string> GetMobileNumberPatterns()
        {
            InitializeDictionary();

            return _mobileNumberPatterns;
        }

        private void InitializeDictionary()
        {
            if (_cultureConfig.ShouldIncludeAfricaMobilePatterns)
            {
                var africaMobileNumberPatterns = new AfricaMobileNumbers();

                africaMobileNumberPatterns.AddAfricaMobileNumberPatterns(_mobileNumberPatterns);
            }

            if (_cultureConfig.ShouldIncludeAmericaMobilePatterns)
            {
                var americaMobileNumberPatterns = new AmericaMobileNumbers();

                americaMobileNumberPatterns.AddAmericaMobileNumberPatterns(_mobileNumberPatterns);
            }

            if (_cultureConfig.ShouldIncludeAsiaMobilePatterns)
            {
                var asiaMobileNumberPatterns = new AsiaMobileNumbers();

                asiaMobileNumberPatterns.AddAsiaMobileNumberPatterns(_mobileNumberPatterns);
            }

            if (!_cultureConfig.ShouldIncludeEuropeMobilePatterns)
            {
                return;
            }

            var europeMobileNumberPatterns = new EuropeMobileNumbers();

            europeMobileNumberPatterns.AddEuropeMobileNumberPatterns(_mobileNumberPatterns);
        }
    }
}