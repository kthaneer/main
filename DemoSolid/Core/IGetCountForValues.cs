using System.Collections.Generic;

namespace Core
{
    public interface IGetCountForValues
    {
        Dictionary<int, int> GetCountForValuesGiven(List<int> lstDistinctValues, List<string> lstValues);
    }
}