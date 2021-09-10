using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using NsExcel = Microsoft.Office.Interop.Excel;

namespace Adapter
{
    class ToExcel:ITarget
    {
        public readonly Adaptee_txt _adaptee;

        public ToExcel(Adaptee_txt temp)
        {
            _adaptee = temp;
        }

        public void AddToExcel(List<string> smth)
        {



            var workbook = new XLWorkbook();
            workbook.AddWorksheet("sheetName");
            var ws = workbook.Worksheet("sheetName");

            int row = 1;
            foreach (object item in smth)
            {
                ws.Cell("A" + row.ToString()).Value = item.ToString();
                row++;
            }

            workbook.SaveAs(@"C:\\Users\\usman\\source\\repos\\ConsoleApp2\\ConsoleApp2\\Test.xlsx");

        }
    }
}
