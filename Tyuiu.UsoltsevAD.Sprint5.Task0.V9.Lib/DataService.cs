﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.UsoltsevAD.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = Math.Round((Math.Pow(x, 3) / (Math.Pow(x, 2) - 1)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
