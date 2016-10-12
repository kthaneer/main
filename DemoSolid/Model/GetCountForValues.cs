using System;
using System.Collections.Generic;
using Core;

namespace Models
{
    public class GetCountForValues : IGetCountForValues
    {
        public Dictionary<int, int> GetCountForValuesGiven(List<int> lstDistinctValues, List<string> lstValues)
        {
            Dictionary<int, int> dictResult = new Dictionary<int, int>();            

            foreach (int i in lstDistinctValues)
            {
                int count = lstValues.FindAll(c => c == i.ToString()).Count;
                dictResult.Add(i, count);
            }

            return dictResult;
        }
    }
}