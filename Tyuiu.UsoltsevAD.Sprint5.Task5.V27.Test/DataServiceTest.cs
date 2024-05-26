using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.UsoltsevAD.Sprint5.Task5.V27.Lib;
namespace Tyuiu.UsoltsevAD.Sprint5.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
