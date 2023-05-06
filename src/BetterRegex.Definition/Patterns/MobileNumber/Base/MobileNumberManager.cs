using BetterRegex.Definition.Types;

namespace BetterRegex.Definition.Patterns.MobileNumber.Base
{
    internal class MobileNumberManager
    {
        protected readonly IDictionary<Countries, string> MobileNumberPatterns;

        public MobileNumberManager()
        {
            MobileNumberPatterns = new Dictionary<Countries, string>();
        }

        public IDictionary<Countries, string> GetMobileNumberPatterns()
        {
            return MobileNumberPatterns;
        }

        private void InitializeDictionary()
        {
            //TODO
        }
    }
}