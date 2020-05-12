using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibs.Utils;
using NUnit.Framework;

namespace AmazonTests.Utils
{
    public class TestDataFromExcel
    {

        public static IEnumerable VerifyData()
        {
            yield return new TestCaseData("Iphone", "Electronics");


        }

        public static IEnumerable VerifyDataFromExcelsheet()
        {
            DataTable testData = ExcelDriver.ReadDataFromExcel("D:/Users/Saurabh Dhingra/source/repos/Learning Selenium/AmazonTests/Amazon.Tests/TestData/InputTestData.xlsx");

            foreach (DataRow row in testData.Rows)
            {
                yield return new TestCaseData(row.ItemArray);

            }

        }

    }
}
