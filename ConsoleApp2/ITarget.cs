using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface ITarget
    {
        void AddToExcel(List<string> smth);
    }
}
