using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KarpenkoNA.Sprint5.Task0.V8.Lib;

namespace Tyuiu.KarpenkoNA.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\duplo\source\repos\Tyuiu.KarpenkoNA.Sprint5\Tyuiu.KarpenkoNA.Sprint5.Task0.V8\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
