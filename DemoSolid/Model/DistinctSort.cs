using System;
using System.Collections.Generic;
using Core;

namespace Models
{
    public class DistinctSort : IDistinctSort
    {
       public List<int> GetDisctinctSortedValues(List<string> lstValues)
        {
            List<int> lstResult = new List<int>();
            int temp;
            foreach (string str in lstValues)
            {
                if (int.TryParse(str,out temp))
                {
                    if (!lstResult.Contains(temp))
                        lstResult.Add(temp);
                }
            }
            lstResult.Sort();
            return lstResult;
        }
    }
}