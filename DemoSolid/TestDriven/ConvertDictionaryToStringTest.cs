using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models;
using Core;

namespace TestDriven
{
    [TestClass]
    public class ConvertDictionaryToStringTest
    {
        [TestMethod]
        public void Given1_1_2_1_3_2ThenDisplay1_1_2_1_3_2()
        {
            //Given: I am a user
            //When: I pass (1, 1), (2,1), (3,2)
            Dictionary<int, int> dictValues = new Dictionary<int, int>();
            dictValues.Add(1, 1);
            dictValues.Add(2, 1);
            dictValues.Add(3, 2);

            IConvertDictionaryToString dictToString = new ConvertDictionaryToString();            
            string result = dictToString.ConvertValuesToString(dictValues);

            //Then: Display 1(1), 2(1) ,3(2)
            Assert.AreEqual("1(1),2(1),3(2)", result);
        }


        [TestMethod]
        public void Given1_1_2_1_4_3ThenDisplay1_1_2_1_4_3()
        {
            //Given: I am a user
            //When: I pass (1, 1), (2,1), (3,2)
            Dictionary<int, int> dictValues = new Dictionary<int, int>();
            dictValues.Add(1, 1);
            dictValues.Add(2, 1);
            dictValues.Add(4, 3);

            IConvertDictionaryToString dictToString = new ConvertDictionaryToString();
            string result = dictToString.ConvertValuesToString(dictValues);

            //Then: Display 1(1), 2(1) ,3(2)
            Assert.AreEqual("1(1),2(1),4(3)", result);
        }
    }
}
