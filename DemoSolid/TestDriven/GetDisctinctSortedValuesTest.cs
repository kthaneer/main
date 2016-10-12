using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Core;

namespace TestDriven
{
    [TestClass]
    public class GetDisctinctSortedValuesTest
    {
        [TestMethod]
        public void Given1_2_3_3ThenResult1_2_3()
        {
            //Given: I am a user
            //When: I enter 1, 2, 3, 3  ( Ignore non-numeric )
            List<string> lstValues = new List<string>();
            lstValues.Add("1");
            lstValues.Add("2");
            lstValues.Add("3");
            lstValues.Add("3");
            IDistinctSort iDistSort = new DistinctSort();
            List<int> lstResult = iDistSort.GetDisctinctSortedValues(lstValues);
            //Then: Display 1, 2 ,3
            List<int> lstExpected = new List<int>(){1, 2, 3 };
            Assert.AreEqual(lstResult[2], lstExpected[2]);
        }

        [TestMethod]
        public void Given1_2_AB_3ThenResult1_2_3()
        {
            //Given: I am a user
            //When: I enter 1, 2, 3, 3  ( Ignore non-numeric )
            List<string> lstValues = new List<string>();
            lstValues.Add("1");
            lstValues.Add("2");
            lstValues.Add("AB");
            lstValues.Add("3");
            IDistinctSort iDistSort = new DistinctSort();
            List<int> lstResult = iDistSort.GetDisctinctSortedValues(lstValues);
            //Then: Display 1, 2 ,3
            List<int> lstExpected = new List<int>() { 1, 2, 3 };
            Assert.AreEqual(lstResult[2], lstExpected[2]);
        }
    }
}
