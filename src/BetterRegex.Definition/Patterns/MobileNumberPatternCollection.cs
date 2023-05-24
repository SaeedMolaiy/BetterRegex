using BetterRegex.Common.Configs;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition.Patterns;

internal class MobileNumberPatternCollection
{
    private readonly RegexCollectionConfig _regexCollectionConfig;
    private readonly IDictionary<Country, string> _mobileNumberPatterns;

    internal MobileNumberPatternCollection(RegexCollectionConfig regexCollectionConfig)
    {
        _mobileNumberPatterns = new Dictionary<Country, string>();

        _regexCollectionConfig = regexCollectionConfig;
    }

    public IDictionary<Country, string> GetMobileNumberPatterns()
    {
        InitializeDictionary();

        return _mobileNumberPatterns;
    }

    private void InitializeDictionary()
    {
        if (_regexCollectionConfig.ShouldIncludeAfricaMobilePatterns)
        {
            AddAfricaMobileNumberPatterns();
        }

        if (_regexCollectionConfig.ShouldIncludeAmericaMobilePatterns)
        {
            AddAmericaMobileNumberPatterns();
        }

        if (_regexCollectionConfig.ShouldIncludeAsiaMobilePatterns)
        {
            AddAsiaMobileNumberPatterns();
        }

        if (_regexCollectionConfig.ShouldIncludeOceaniaMobilePatterns)
        {
            AddOceaniaMobileNumberPatterns();
        }

        if (!_regexCollectionConfig.ShouldIncludeEuropeMobilePatterns)
        {
            return;
        }

        AddEuropeMobileNumberPatterns();
    }

    private void AddAfricaMobileNumberPatterns()
    {
        _mobileNumberPatterns.Add(Country.Algeria, "/^(00213|+213)?(5\\d{8}|6[015678]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Angola, "/^(00244|+244)?(9[123456]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Benin, "/^(00229|+229)?(9[678]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Botswana, "/^(00267|+267)?(7[06789]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.BurkinaFaso, "/^(00226|+226)?(6[56789]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Burundi, "/^(00257|+257)?(7[89]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.CapeVerde, "/^(00238|+238)?(9[56789]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.CentralAfricanRepublic, "/^(00236|+236)?(7[0123459]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Chad, "/^(00235|+235)?(6[67]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Comoros, "/^(00269|+269)?(3[012345678]\\d{5})$/");
        _mobileNumberPatterns.Add(Country.Congo, "/^(00242|+242)?(0[679]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Djibouti, "/^(00253|+253)?(77[4-9]\\d{5})$/");
        _mobileNumberPatterns.Add(Country.Egypt, "/^(0020|+20)?(1\\d{9})$/");
        _mobileNumberPatterns.Add(Country.EquatorialGuinea, "/^(00240|+240)?(222[012]\\d{4})$/");
        _mobileNumberPatterns.Add(Country.Eritrea, "/^(00291|+291)?(7[012]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Eswatini, "/^(00268|+268)?(7[689]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Ethiopia, "/^(00251|+251)?(9[1-9]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Gabon, "/^(00241|+241)?(0[578]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Gambia, "/^(00220|+220)?(7[6789]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Ghana, "/^(00233|+233)?(2[0345679]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Guinea, "/^(00224|+224)?(6[2356]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.GuineaBissau, "/^(00245|+245)?(6[235]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Kenya, "/^(00254|+254)?(7\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Lesotho, "/^(00266|+266)?(5[234567]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Liberia, "/^(00231|+231)?(77[012345678]\\d{5})$/");
        _mobileNumberPatterns.Add(Country.Libya, "/^(00218|+218)?(9[12]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Madagascar, "/^(00261|+261)?(3[0345679]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Malawi, "/^(00265|+265)?(88[123456789]\\d{5})$/");
        _mobileNumberPatterns.Add(Country.Mali, "/^(00223|+223)?(6[0356789]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Mauritania, "/^(00222|+222)?(3[378]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Mauritius, "/^(00230|+230)?(5[234]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Morocco, "/^(00212|+212)?(6\\d{8}|[789]\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Mozambique, "/^(00258|+258)?(8[1345679]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Namibia, "/^(00264|+264)?(81[23456789]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Niger, "/^(00227|+227)?(9[67]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Nigeria, "/^(00234|+234)?(8[013456789]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Rwanda, "/^(00250|+250)?(7[25678]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.SaoTomeAndPrincipe, "/^(00239|+239)?(9[012345]\\d{5})$/");
        _mobileNumberPatterns.Add(Country.Senegal, "/^(00221|+221)?(7[056]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.SierraLeone, "/^(00232|+232)?(9[567]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Somalia, "/^(00252|+252)?(6[01256789]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.SouthAfrica, "/^(0027|+27)?(6\\d{8})$/");
        _mobileNumberPatterns.Add(Country.SouthSudan, "/^(00211|+211)?(9[178]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Sudan, "/^(00249|+249)?(9[012345678]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Tanzania, "/^(00255|+255)?(6\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Togo, "/^(00228|+228)?(9\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Tunisia, "/^(00216|+216)?(9[12]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Uganda, "/^(00256|+256)?(7\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Zambia, "/^(00260|+260)?(9[56789]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Zimbabwe, "/^(00263|+263)?(7[12345678]\\d{7})$/");
    }

    private void AddAmericaMobileNumberPatterns()
    {
        //North America
        _mobileNumberPatterns.Add(Country.AntiguaAndBarbuda, "/^(001268|+1-268)?(7\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Bahamas, "/^(001242|+1-242)?(4\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Barbados, "/^(001246|+1-246)?(2\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Belize, "/^(00501|+501)?(6\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Canada, "/^(001|+1)?([2-9]\\d{9})$/");
        _mobileNumberPatterns.Add(Country.CostaRica, "/^(00506|+506)?([2-9]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Cuba, "/^(0053|+53)?(5\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Dominica, "/^(001767|+1-767)?(2\\d{6})$/");
        _mobileNumberPatterns.Add(Country.DominicanRepublic, "/^(001809|001829|001849|+1-809|+1-829|+1-849)?(8\\d{7})$/");
        _mobileNumberPatterns.Add(Country.ElSalvador, "/^(00503|+503)?(6\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Grenada, "/^(001473|+1-473)?(4\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Guatemala, "/^(00502|+502)?(4\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Haiti, "/^(00509|+509)?(4\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Honduras, "/^(00504|+504)?(9\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Jamaica, "/^(001876|+1-876)?(7\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Mexico, "/^(0052|+52)?(1\\d{10})$/");
        _mobileNumberPatterns.Add(Country.Nicaragua, "/^(00505|+505)?(8\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Panama, "/^(00507|+507)?(6\\d{7})$/");
        _mobileNumberPatterns.Add(Country.SaintKittsAndNevis, "/^(001869|+1-869)?(6\\d{6})$/");
        _mobileNumberPatterns.Add(Country.SaintLucia, "/^(001758|+1-758)?(5\\d{6})$/");
        _mobileNumberPatterns.Add(Country.SaintVincentAndGrenadines, "/^(001784|+1-784)?(4\\d{6})$/");
        _mobileNumberPatterns.Add(Country.TrinidadAndTobago, "/^(001868|+1-868)?(7\\d{6})$/");
        _mobileNumberPatterns.Add(Country.UnitedStates, "/^(001|+1)?([2-9]\\d{9})$/");

        //South America
        _mobileNumberPatterns.Add(Country.Argentina, "/^(0054|+54|0)(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Bolivia, "/^(00591|+591)(6|7)\\d{7}$/");
        _mobileNumberPatterns.Add(Country.Brazil, "/^(0055|+55|0)([679])?(\\d{2})(\\d{4,5})(\\d{4})$/");
        _mobileNumberPatterns.Add(Country.Chile, "/^(0056|+56|0)?(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Colombia, "/^(0057|+57)(3\\d{9})$/");
        _mobileNumberPatterns.Add(Country.Ecuador, "/^(00593|+593)(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Guyana, "/^(00592|+592)(6\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Paraguay, "/^(00595|+595)(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Peru, "/^(0051|+51|0)?(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Suriname, "/^(00597|+597)(6\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Uruguay, "/^(00598|+598|0)(9\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Venezuela, "/^(0058|+58|0)(4\\d{9})$/");
    }

    private void AddAsiaMobileNumberPatterns()
    {
    }

    private void AddOceaniaMobileNumberPatterns()
    {
        _mobileNumberPatterns.Add(Country.Australia, "/^(0061|+61|0)[1-9]\\d{8}$/");
        _mobileNumberPatterns.Add(Country.Fiji, "/^(00679|+679)(7|8)\\d{6}$/");
        _mobileNumberPatterns.Add(Country.Kiribati, "/^(00686|+686)(9\\d{6}|2\\d{5})$/");
        _mobileNumberPatterns.Add(Country.MarshallIslands, "/^(00692|+692)\\d{7}$/");
        _mobileNumberPatterns.Add(Country.Micronesia, "/^(00691|+691)(3|9)\\d{6}$/");
        _mobileNumberPatterns.Add(Country.Nauru, "/^(00674|+674)\\d{7}$/");
        _mobileNumberPatterns.Add(Country.NewZealand, "/^(0064|+64|0)[28]\\d{7,9}$/");
        _mobileNumberPatterns.Add(Country.Palau, "/^(00680|+680)\\d{7}$/");
        _mobileNumberPatterns.Add(Country.PapuaNewGuinea, "/^(00675|+675)(7[45678]|8[12])\\d{6}$/");
        _mobileNumberPatterns.Add(Country.Samoa, "/^(00685|+685)[7238]\\d{6}$/");
        _mobileNumberPatterns.Add(Country.SolomonIslands, "/^(00677|+677)[78]\\d{6}$/");
        _mobileNumberPatterns.Add(Country.Tonga, "/^(00676|+676)7\\d{6}$/");
        _mobileNumberPatterns.Add(Country.Tuvalu, "/^(00688|+688)(90[1-9]|91[0-4])\\d{4}$/");
        _mobileNumberPatterns.Add(Country.Vanuatu, "/^(00678|+678)[56789]\\d{5}$/");
    }

    private void AddEuropeMobileNumberPatterns()
    {
        _mobileNumberPatterns.Add(Country.Albania, "/^(00355|+355)?(6\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Andorra, "/^(00376|+376)?(6\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Australia, "/^(0043|+43)?(6\\d{8,9})$/");
        _mobileNumberPatterns.Add(Country.Belarus, "/^(00375|+375)?(\\d{9})$/");
        _mobileNumberPatterns.Add(Country.Belgium, "/^(0032|+32)?(4\\d{8})$/");
        _mobileNumberPatterns.Add(Country.BosniaAndHerzegovina, "/^(00387|+387)?([6-9]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Bulgaria, "/^(00359|+359)?(8\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Croatia, "/^(00385|+385)?(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Cyprus, "/^(00357|+357)?(9\\d{7})$/");
        _mobileNumberPatterns.Add(Country.CzechRepublic, "/^(00420|+420)?([6-9]\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Denmark, "/^(0045|+45)?(\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Estonia, "/^(00372|+372)?([5-8]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Finland, "/^(00358|+358)?(4\\d{8})$/");
        _mobileNumberPatterns.Add(Country.France, "/^(0033|+33)?(6\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Germany, "/^(0049|+49)?([1-9]\\d{8,12})$/");
        _mobileNumberPatterns.Add(Country.Greece, "/^(0030|+30)?(6\\d{9})$/");
        _mobileNumberPatterns.Add(Country.Hungary, "/^(0036|+36)?(20\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Iceland, "/^(00354|+354)?([6-9]\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Ireland, "/^(00353|+353)?(8\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Italy, "/^(0039|+39)?(3\\d{9})$/");
        _mobileNumberPatterns.Add(Country.Latvia, "/^(00371|+371)?([2-9]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Liechtenstein, "/^(00423|+423)?(\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Lithuania, "/^(00370|+370)?(6\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Luxembourg, "/^(00352|+352)?(\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Malta, "/^(00356|+356)?(79\\d{6})$/");
        _mobileNumberPatterns.Add(Country.Moldova, "/^(00373|+373)?(6\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Monaco, "/^(00377|+377)?(\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Montenegro, "/^(00382|+382)?([67]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Netherlands, "/^(0031|+31)?(6\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Macedonia, "/^(00389|+389)?(7\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Macedonia, "/^(00389|+389)?(7\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Norway, "/^(0047|+47)?([49]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Poland, "/^(0048|+48)?(5\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Portugal, "/^(00351|+351)?(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Romania, "/^(0040|+40)?(7[2-8]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.RussianFederation, "/^(007|+7)?(\\d{10})$/");
        _mobileNumberPatterns.Add(Country.SanMarino, "/^(00378|+378)?(\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Serbia, "/^(00381|+381)?([6-7]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Slovakia, "/^(00421|+421)?([6-9]\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Slovenia, "/^(00386|+386)?([3-9]\\d{7})$/");
        _mobileNumberPatterns.Add(Country.Spain, "/^(0034|+34)?(6\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Sweden, "/^(0046|+46)?(7\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Switzerland, "/^(0041|+41)?(7\\d{8})$/");
        _mobileNumberPatterns.Add(Country.Ukraine, "/^(00380|+380)?(9\\d{8})$/");
        _mobileNumberPatterns.Add(Country.UnitedKingdom, "/^(0044|+44)?(7\\d{9})$/");
        _mobileNumberPatterns.Add(Country.HolySeeVaticanCityState, "/^(00379|+379)?(\\d{8})$/");
    }
}