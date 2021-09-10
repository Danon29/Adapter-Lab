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
        public void Read_txt(string _path)
        {
            var path = _path; // Путь к произвольному текстовому файлу
            var myList = File.ReadAllLines(path);
            list.AddRange(myList);
            Console.WriteLine(_path);
            for (int i = 0; i < count; i++)
            {
                list.Add(myList[i]);
            }

        }

    }
}

