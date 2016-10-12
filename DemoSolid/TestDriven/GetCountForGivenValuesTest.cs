using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models;
using Core;

namespace TestDriven
{
    [TestClass]
    public class GetCountForGivenValuesTest
    {
        [TestMethod]
        public void Given1_2_3And1_2_3_3_ThenReturn1_1_2_1_3_2()
        {
            //Given: I am a user
            //When: I enter  1, 2, 3,  and 1,2,3,3
            List<int> lstDistinct = new List<int>() { 1, 2, 3 };
            List<string> lstValues = new List<string>() { "1", "2", "3", "3" };
            IGetCountForValues iGetCount = new GetCountForValues();
            Dictionary<int, int> dictValues = iGetCount.GetCountForValuesGiven(lstDistinct, lstValues);
            // Then: Dispay 1(1),2(1),3(2)
            Dictionary<int, int> dictExpected = new Dictionary<int, int>();
            dictExpected.Add(1, 1);
            dictExpected.Add(2, 1);
            dictExpected.Add(3, 2);
            Assert.AreEqual(dictExpected[2], dictValues[2]);
        }

        [TestMethod]
        public void Given6_8_9And_8_AB_9_CD_6_ThenReturn6_1_8_1_9_1()
        {
            //Given: I am a user
            //When: I enter  1, 2, 3,  and 1,2,3,3
            List<int> lstDistinct = new List<int>() { 6, 8, 9 };
            List<string> lstValues = new List<string>() { "8", "AB", "9", "CD", "6" };
            IGetCountForValues iGetCount = new GetCountForValues();
            Dictionary<int, int> dictValues = iGetCount.GetCountForValuesGiven(lstDistinct, lstValues);
            // Then: Dispay 1(1),2(1),3(2)
            Dictionary<int, int> dictExpected = new Dictionary<int, int>();
            dictExpected.Add(6, 1);
            dictExpected.Add(8, 1);
            dictExpected.Add(9, 1);
            Assert.AreEqual(dictExpected[9], dictValues[9]);
        }
    }
}
