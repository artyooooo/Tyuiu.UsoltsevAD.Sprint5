using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.UsoltsevAD.Sprint5.Task2.V4.Lib;
namespace Tyuiu.UsoltsevAD.Sprint5.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\malsu\source\repos\Tyuiu.UsoltsevAD.Sprint5\Tyuiu.UsoltsevAD.Sprint5.Task2.V4\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
