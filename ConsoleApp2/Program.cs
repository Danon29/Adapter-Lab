using Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var smth = new Adaptee_txt();
            smth.Read_txt(Console.ReadLine());
            var smth2 = new Adapter_Excel(smth);
           // smth2.AddToExcel();
        }
    }
}
