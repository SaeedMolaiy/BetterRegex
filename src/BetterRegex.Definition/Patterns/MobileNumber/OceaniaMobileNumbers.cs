using BetterRegex.Common.Helpers;
using BetterRegex.Common.Infrastructure;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition.Patterns.MobileNumber
{
    internal class OceaniaMobileNumbers : IDictionaryInitializer
    {
        private readonly IDictionary<Country, string> _mobilePatterns;

        public OceaniaMobileNumbers()
        {
            _mobilePatterns = new Dictionary<Country, string>();
        }

        public void AddOceaniaMobileNumberPatterns(IDictionary<Country, string> dictionary)
        {
            Initialize();

            dictionary.MergeDictionaries(_mobilePatterns);
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}