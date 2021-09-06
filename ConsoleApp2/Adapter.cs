using System;
using System.IO;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Adapter
{

    class Adapter_Excel : ITarget
    {
        public readonly Adaptee_txt _adaptee;

        public Adapter_Excel(Adaptee_txt temp)
        {
            _adaptee = temp;
        }

        public void AddToExcel()
        {
            string fileName = "C:\\chtoto.xlsx"; //имя Excel файла  
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWb = xlApp.Workbooks.Open(fileName); 
            Excel.Worksheet xlSht = xlWb.Sheets[1]; //первый лист в файле

            xlSht.Cells[1, "a"] = _adaptee.list[0].ToString();
            xlSht.Cells[2, "a"] = _adaptee.list[1].ToString();
            xlSht.Cells[3, "a"] = _adaptee.list[2].ToString();
            xlSht.Cells[4, "a"] = _adaptee.list[3].ToString();
            xlSht.Cells[5, "a"] = _adaptee.list[4].ToString();
            xlSht.Cells[6, "a"] = _adaptee.list[5].ToString();
            xlSht.Cells[7, "a"] = _adaptee.list[6].ToString();


            xlWb.Close(true); 
            xlApp.Quit();
        }

      
    }


    
    }


