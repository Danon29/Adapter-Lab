using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Adapter
{
    class Adaptee_txt
    {
        public int count;
        public List<string> list = new List<string>() { "1" };
        public void Read_txt()
        {
            var path = @"C:\\Text.txt"; // Путь к произвольному текстовому файлу
            var myList = File.ReadAllLines(path);
            list.AddRange(myList);

            for (int i = 0; i < count; i++)
            {
                list.Add(myList[i]);
            }

        }

    }
}
