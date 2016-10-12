using System;
using System.Collections.Generic;
using Core;

namespace Models
{
    public class SortValues : ISortValues
    {
        public string SortTheValuesAndProvideCount(List<string> lstValues)
        {
            string result = string.Empty;
           
            // step 1 Getting disctinct values
            IDistinctSort sortValue = new DistinctSort();
            List<int> lstSortValues = sortValue.GetDisctinctSortedValues(lstValues);

            // Step 2 - Get the count for each values
            IGetCountForValues getcount = new GetCountForValues();
            Dictionary<int, int> dictResult = getcount.GetCountForValuesGiven(lstSortValues, lstValues);

            // Step 3 - Convert to string
            IConvertDictionaryToString dictString = new ConvertDictionaryToString();
            result = dictString.ConvertValuesToString(dictResult);
            return result;
        }
    }
}