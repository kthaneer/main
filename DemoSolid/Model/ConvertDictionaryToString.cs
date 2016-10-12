using System;
using System.Collections.Generic;
using Core;

namespace Models
{
    public class ConvertDictionaryToString : IConvertDictionaryToString
    {
        public string ConvertValuesToString(Dictionary<int, int> dictValues)
        {
            string result = string.Empty;
            foreach (var element in dictValues)
            {
                if (result == string.Empty)
                {
                    result += element.Key + "(" + element.Value + ")";
                }
                else
                {
                    result += "," + element.Key + "(" + element.Value + ")";
                }
            }
            return result;
        }
    }
}