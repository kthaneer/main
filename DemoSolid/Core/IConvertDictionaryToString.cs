using System.Collections.Generic;

namespace Core
{
    public interface IConvertDictionaryToString
    {
        string ConvertValuesToString(Dictionary<int, int> dictValues);
    }
}