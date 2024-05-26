using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.UsoltsevAD.Sprint5.Task7.V23.Lib;
namespace Tyuiu.UsoltsevAD.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
