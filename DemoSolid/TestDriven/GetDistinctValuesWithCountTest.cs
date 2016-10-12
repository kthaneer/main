using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models;
using Core;

namespace TestDriven
{
    [TestClass]
    public class GetDistinctValuesWithCountTest
    {
        [TestMethod]
        public void Given1_2_3_3ThenDisplay1_2_3()
        {
            //Given: I am a user
            //When: I enter  1, 2, 3, 3
            List<string> lstValues = new List<string>();
            lstValues.Add("1");
            lstValues.Add("2");
            lstValues.Add("3");
            lstValues.Add("3");
            ISortValues isort = new SortValues();
            string result = isort.SortTheValuesAndProvideCount(lstValues);
            //Then: Display 1, 2, 3
            string expected = "1(1),2(1),3(2)";         
            Assert.AreEqual(expected, result);

        }

        //Given: I am a user
        //When: I enter 8, 7, 9, 6, 6
        //Then: Display 6(2), 7(1), 8(1), 9(1)
        [TestMethod]
        public void Given8_7_9_6_6ThenDisplay6_2_7_1_8_1_9_1()
        {
            //Given: I am a user
            //When: I enter 8, 7, 9, 6, 6
            List<string> lstValues = new List<string>();
            lstValues.Add("8");
            lstValues.Add("7");
            lstValues.Add("9");
            lstValues.Add("6");
            lstValues.Add("6");
            ISortValues isort = new SortValues();
            string result = isort.SortTheValuesAndProvideCount(lstValues);
            //Then: Display 6(2), 7(1), 8(1), 9(1)
            string expected = "6(2),7(1),8(1),9(1)";
            Assert.AreEqual(expected, result);

        }

        //Given: I am a user 
        // When: I enter 8, AB,*, , 9, CD, 6  ( Ignore non-numeric )
        //Then: Display 6(1), 8(1), 9(1)
        [TestMethod]
        public void Given8_AB_9_CD_6ThenDisplay6_1_8_1_9_1()
        {
            //Given: I am a user
            //When: I enter 8, AB, 9, CD, 6  ( Ignore non-numeric )
            List<string> lstValues = new List<string>();
            lstValues.Add("8");
            lstValues.Add("AB");
            lstValues.Add("*");
            lstValues.Add(" ");
            lstValues.Add("9");
            lstValues.Add("CD");
            lstValues.Add("6");
            ISortValues isort = new SortValues();
            string result = isort.SortTheValuesAndProvideCount(lstValues);
            //Then: Display 6(1), 8(1), 9(1)
            string expected = "6(1),8(1),9(1)";
            Assert.AreEqual(expected, result);

        }
    }
}
