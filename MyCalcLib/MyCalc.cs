 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;

namespace MyCalcLib
{
    public class MyCalc
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}