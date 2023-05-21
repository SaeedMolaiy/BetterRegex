using BetterRegex.Common.Helpers;
using BetterRegex.Common.Infrastructure;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition.Patterns.MobileNumber;

internal class AmericaMobileNumbers : IDictionaryInitializer
{
    private readonly IDictionary<Country, string> _mobilePatterns;

    public AmericaMobileNumbers()
    {
        _mobilePatterns = new Dictionary<Country, string>();
    }

    public void AddAmericaMobileNumberPatterns(IDictionary<Country, string> dictionary)
    {
        Initialize();

        dictionary.MergeDictionaries(_mobilePatterns);
    }

    public void Initialize()
    {
        //North America
        _mobilePatterns.Add(Country.AntiguaAndBarbuda, "/^(001268|+1-268)?(7\\d{6})$/");
        _mobilePatterns.Add(Country.Bahamas, "/^(001242|+1-242)?(4\\d{6})$/");
        _mobilePatterns.Add(Country.Barbados, "/^(001246|+1-246)?(2\\d{6})$/");
        _mobilePatterns.Add(Country.Belize, "/^(00501|+501)?(6\\d{6})$/");
        _mobilePatterns.Add(Country.Canada, "/^(001|+1)?([2-9]\\d{9})$/");
        _mobilePatterns.Add(Country.CostaRica, "/^(00506|+506)?([2-9]\\d{7})$/");
        _mobilePatterns.Add(Country.Cuba, "/^(0053|+53)?(5\\d{7})$/");
        _mobilePatterns.Add(Country.Dominica, "/^(001767|+1-767)?(2\\d{6})$/");
        _mobilePatterns.Add(Country.DominicanRepublic, "/^(001809|001829|001849|+1-809|+1-829|+1-849)?(8\\d{7})$/");
        _mobilePatterns.Add(Country.ElSalvador, "/^(00503|+503)?(6\\d{7})$/");
        _mobilePatterns.Add(Country.Grenada, "/^(001473|+1-473)?(4\\d{6})$/");
        _mobilePatterns.Add(Country.Guatemala, "/^(00502|+502)?(4\\d{7})$/");
        _mobilePatterns.Add(Country.Haiti, "/^(00509|+509)?(4\\d{7})$/");
        _mobilePatterns.Add(Country.Honduras, "/^(00504|+504)?(9\\d{7})$/");
        _mobilePatterns.Add(Country.Jamaica, "/^(001876|+1-876)?(7\\d{6})$/");
        _mobilePatterns.Add(Country.Mexico, "/^(0052|+52)?(1\\d{10})$/");
        _mobilePatterns.Add(Country.Nicaragua, "/^(00505|+505)?(8\\d{7})$/");
        _mobilePatterns.Add(Country.Panama, "/^(00507|+507)?(6\\d{7})$/");
        _mobilePatterns.Add(Country.SaintKittsAndNevis, "/^(001869|+1-869)?(6\\d{6})$/");
        _mobilePatterns.Add(Country.SaintLucia, "/^(001758|+1-758)?(5\\d{6})$/");
        _mobilePatterns.Add(Country.SaintVincentAndGrenadines, "/^(001784|+1-784)?(4\\d{6})$/");
        _mobilePatterns.Add(Country.TrinidadAndTobago, "/^(001868|+1-868)?(7\\d{6})$/");
        _mobilePatterns.Add(Country.UnitedStates, "/^(001|+1)?([2-9]\\d{9})$/");

        //South America
        _mobilePatterns.Add(Country.Argentina, "/^(0054|+54|0)(9\\d{8})$/");
        _mobilePatterns.Add(Country.Bolivia, "/^(00591|+591)(6|7)\\d{7}$/");
        _mobilePatterns.Add(Country.Brazil, "/^(0055|+55|0)([679])?(\\d{2})(\\d{4,5})(\\d{4})$/");
        _mobilePatterns.Add(Country.Chile, "/^(0056|+56|0)?(9\\d{8})$/");
        _mobilePatterns.Add(Country.Colombia, "/^(0057|+57)(3\\d{9})$/");
        _mobilePatterns.Add(Country.Ecuador, "/^(00593|+593)(9\\d{8})$/");
        _mobilePatterns.Add(Country.Guyana, "/^(00592|+592)(6\\d{6})$/");
        _mobilePatterns.Add(Country.Paraguay, "/^(00595|+595)(9\\d{8})$/");
        _mobilePatterns.Add(Country.Peru, "/^(0051|+51|0)?(9\\d{8})$/");
        _mobilePatterns.Add(Country.Suriname, "/^(00597|+597)(6\\d{6})$/");
        _mobilePatterns.Add(Country.Uruguay, "/^(00598|+598|0)(9\\d{7})$/");
        _mobilePatterns.Add(Country.Venezuela, "/^(0058|+58|0)(4\\d{9})$/");
    }
}