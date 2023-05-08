﻿using BetterRegex.Definition.Patterns;

using BetterRegex.Common.Configs;

namespace BetterRegex.Definition;

using BetterRegex.Common.Types;

public class CultureManager
{
    private readonly MobileNumberCollection _mobileNumberCollection;
    private IDictionary<Country, string> _mobileNumberDictionary;

    public CultureManager(CultureConfig cultureConfig)
    {
        _mobileNumberDictionary = new Dictionary<Country, string>();
        _mobileNumberCollection = new MobileNumberCollection(cultureConfig);

        InitializeMobileNumberDirectory();
    }

    public string GetMobileNumberPattern(Country country)
    {
        return _mobileNumberDictionary.SingleOrDefault(
            x => x.Key == country).Value;
    }

    private void InitializeMobileNumberDirectory()
        => _mobileNumberDictionary = _mobileNumberCollection.GetMobileNumberPatterns();
}