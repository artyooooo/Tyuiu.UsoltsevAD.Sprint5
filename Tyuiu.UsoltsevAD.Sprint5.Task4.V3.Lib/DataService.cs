﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.UsoltsevAD.Sprint5.Task4.V3.Lib
{
    public class DataService : ISprint5Task4V3
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x;
            x = Convert.ToDouble(strX);
            double res = Math.Round((Math.Sin(x) + 4) / 4 - 1.25 * Convert.ToDouble(x), 3);
            return res;
        }
    }
}
