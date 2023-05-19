using BetterRegex.Common.Helpers;
using BetterRegex.Common.Infrastructure;
using BetterRegex.Common.Types;

namespace BetterRegex.Definition.Patterns.MobileNumber;

internal class AfricaMobileNumbers : IDictionaryInitializer
{
    private readonly IDictionary<Country, string> _mobilePatterns;

    public AfricaMobileNumbers()
    {
        _mobilePatterns = new Dictionary<Country, string>();
    }

    public void AddAfricaMobileNumberPatterns(IDictionary<Country, string> dictionary)
    {
        Initialize();

        dictionary.MergeDictionaries(_mobilePatterns);
    }

    public void Initialize()
    {
        _mobilePatterns.Add(Country.Algeria, "/^(00213|+213)?(5\\d{8}|6[015678]\\d{7})$/");
        _mobilePatterns.Add(Country.Angola, "/^(00244|+244)?(9[123456]\\d{7})$/");
        _mobilePatterns.Add(Country.Benin, "/^(00229|+229)?(9[678]\\d{7})$/");
        _mobilePatterns.Add(Country.Botswana, "/^(00267|+267)?(7[06789]\\d{7})$/");
        _mobilePatterns.Add(Country.BurkinaFaso, "/^(00226|+226)?(6[56789]\\d{7})$/");
        _mobilePatterns.Add(Country.Burundi, "/^(00257|+257)?(7[89]\\d{6})$/");
        _mobilePatterns.Add(Country.CapeVerde, "/^(00238|+238)?(9[56789]\\d{6})$/");
        _mobilePatterns.Add(Country.CentralAfricanRepublic, "/^(00236|+236)?(7[0123459]\\d{6})$/");
        _mobilePatterns.Add(Country.Chad, "/^(00235|+235)?(6[67]\\d{7})$/");
        _mobilePatterns.Add(Country.Comoros, "/^(00269|+269)?(3[012345678]\\d{5})$/");
        _mobilePatterns.Add(Country.Congo, "/^(00242|+242)?(0[679]\\d{7})$/");
        _mobilePatterns.Add(Country.Djibouti, "/^(00253|+253)?(77[4-9]\\d{5})$/");
        _mobilePatterns.Add(Country.Egypt, "/^(0020|+20)?(1\\d{9})$/");
        _mobilePatterns.Add(Country.EquatorialGuinea, "/^(00240|+240)?(222[012]\\d{4})$/");
        _mobilePatterns.Add(Country.Eritrea, "/^(00291|+291)?(7[012]\\d{6})$/");
        _mobilePatterns.Add(Country.Eswatini, "/^(00268|+268)?(7[689]\\d{7})$/");
        _mobilePatterns.Add(Country.Ethiopia, "/^(00251|+251)?(9[1-9]\\d{7})$/");
        _mobilePatterns.Add(Country.Gabon, "/^(00241|+241)?(0[578]\\d{7})$/");
        _mobilePatterns.Add(Country.Gambia, "/^(00220|+220)?(7[6789]\\d{6})$/");
        _mobilePatterns.Add(Country.Ghana, "/^(00233|+233)?(2[0345679]\\d{7})$/");
        _mobilePatterns.Add(Country.Guinea, "/^(00224|+224)?(6[2356]\\d{7})$/");
        _mobilePatterns.Add(Country.GuineaBissau, "/^(00245|+245)?(6[235]\\d{6})$/");
        _mobilePatterns.Add(Country.Kenya, "/^(00254|+254)?(7\\d{8})$/");
        _mobilePatterns.Add(Country.Lesotho, "/^(00266|+266)?(5[234567]\\d{6})$/");
        _mobilePatterns.Add(Country.Liberia, "/^(00231|+231)?(77[012345678]\\d{5})$/");
        _mobilePatterns.Add(Country.Libya, "/^(00218|+218)?(9[12]\\d{7})$/");
        _mobilePatterns.Add(Country.Madagascar, "/^(00261|+261)?(3[0345679]\\d{7})$/");
        _mobilePatterns.Add(Country.Malawi, "/^(00265|+265)?(88[123456789]\\d{5})$/");
        _mobilePatterns.Add(Country.Mali, "/^(00223|+223)?(6[0356789]\\d{7})$/");
        _mobilePatterns.Add(Country.Mauritania, "/^(00222|+222)?(3[378]\\d{6})$/");
        _mobilePatterns.Add(Country.Mauritius, "/^(00230|+230)?(5[234]\\d{6})$/");
        _mobilePatterns.Add(Country.Morocco, "/^(00212|+212)?(6\\d{8}|[789]\\d{8})$/");
        _mobilePatterns.Add(Country.Mozambique, "/^(00258|+258)?(8[1345679]\\d{7})$/");
        _mobilePatterns.Add(Country.Namibia, "/^(00264|+264)?(81[23456789]\\d{6})$/");
        _mobilePatterns.Add(Country.Niger, "/^(00227|+227)?(9[67]\\d{7})$/");
        _mobilePatterns.Add(Country.Nigeria, "/^(00234|+234)?(8[013456789]\\d{7})$/");
        _mobilePatterns.Add(Country.Rwanda, "/^(00250|+250)?(7[25678]\\d{7})$/");
        _mobilePatterns.Add(Country.SaoTomeAndPrincipe, "/^(00239|+239)?(9[012345]\\d{5})$/");
        _mobilePatterns.Add(Country.Senegal, "/^(00221|+221)?(7[056]\\d{6})$/");
        _mobilePatterns.Add(Country.SierraLeone, "/^(00232|+232)?(9[567]\\d{7})$/");
        _mobilePatterns.Add(Country.Somalia, "/^(00252|+252)?(6[01256789]\\d{7})$/");
        _mobilePatterns.Add(Country.SouthAfrica, "/^(0027|+27)?(6\\d{8})$/");
        _mobilePatterns.Add(Country.SouthSudan, "/^(00211|+211)?(9[178]\\d{7})$/");
        _mobilePatterns.Add(Country.Sudan, "/^(00249|+249)?(9[012345678]\\d{7})$/");
        _mobilePatterns.Add(Country.Tanzania, "/^(00255|+255)?(6\\d{8})$/");
        _mobilePatterns.Add(Country.Togo, "/^(00228|+228)?(9\\d{7})$/");
        _mobilePatterns.Add(Country.Tunisia, "/^(00216|+216)?(9[12]\\d{7})$/");
        _mobilePatterns.Add(Country.Uganda, "/^(00256|+256)?(7\\d{8})$/");
        _mobilePatterns.Add(Country.Zambia, "/^(00260|+260)?(9[56789]\\d{7})$/");
        _mobilePatterns.Add(Country.Zimbabwe, "/^(00263|+263)?(7[12345678]\\d{7})$/");
    }
}