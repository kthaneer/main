using System.Collections.Generic;

namespace Core
{
    public interface IDistinctSort
    {
        List<int> GetDisctinctSortedValues(List<string> lstValues);
    }
}