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
            _mobilePatterns.Add(Country.Australia, "/^(0061|+61|0)[1-9]\\d{8}$/");
            _mobilePatterns.Add(Country.Fiji, "/^(00679|+679)(7|8)\\d{6}$/");
            _mobilePatterns.Add(Country.Kiribati, "/^(00686|+686)(9\\d{6}|2\\d{5})$/");
            _mobilePatterns.Add(Country.MarshallIslands, "/^(00692|+692)\\d{7}$/");
            _mobilePatterns.Add(Country.Micronesia, "/^(00691|+691)(3|9)\\d{6}$/");
            _mobilePatterns.Add(Country.Nauru, "/^(00674|+674)\\d{7}$/");
            _mobilePatterns.Add(Country.NewZealand, "/^(0064|+64|0)[28]\\d{7,9}$/");
            _mobilePatterns.Add(Country.Palau, "/^(00680|+680)\\d{7}$/");
            _mobilePatterns.Add(Country.PapuaNewGuinea, "/^(00675|+675)(7[45678]|8[12])\\d{6}$/");
            _mobilePatterns.Add(Country.Samoa, "/^(00685|+685)[7238]\\d{6}$/");
            _mobilePatterns.Add(Country.SolomonIslands, "/^(00677|+677)[78]\\d{6}$/");
            _mobilePatterns.Add(Country.Tonga, "/^(00676|+676)7\\d{6}$/");
            _mobilePatterns.Add(Country.Tuvalu, "/^(00688|+688)(90[1-9]|91[0-4])\\d{4}$/");
            _mobilePatterns.Add(Country.Vanuatu, "/^(00678|+678)[56789]\\d{5}$/");
        }
    }
}