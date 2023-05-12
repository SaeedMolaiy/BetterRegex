using BetterRegex.Common.Types;

namespace BetterRegex.Common.Helpers;

public static class DictionaryHelper
{
    public static void MergeDictionaries(this IDictionary<Country, string> dictionary,
                                         IDictionary<Country, string> mergeDictionary)
    {
        foreach (var pattern in mergeDictionary)
        {
            if (!dictionary.ContainsKey(pattern.Key))
            {
                dictionary.Add(pattern);
            }
        }
    }
}