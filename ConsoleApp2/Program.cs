using Adapter;
using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var smth = new Adaptee_txt();
            Console.WriteLine("Введите путь до файла txt");

            smth.Read_txt(Console.ReadLine());

            var smth2 = new ToExcel(smth);
            smth2.AddToExcel(smth2._adaptee.list);

        }
    }
}
