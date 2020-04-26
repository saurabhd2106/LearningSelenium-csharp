using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;

namespace CommonLibs.Utils
{
    public class ExcelDriver
    {

        public static DataTable ReadDataFromExcel(string filename)
        {
            _ = filename.Trim();

            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader;

            if (filename.EndsWith(".xls") || filename.EndsWith(".xlsx"))
            {
                excelReader = ExcelReaderFactory.CreateReader(stream);

            }
            else
            {
                throw new Exception("Invalid File Type");
            }

            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            DataTableCollection allTables = result.Tables;

            DataTable dataTable = allTables["testData"];

            return dataTable;
        }
    }
}
