using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KarpenkoNA.Sprint5.Task6.V20.Lib;

namespace Tyuiu.KarpenkoNA.Sprint5.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\duplo\source\repos\Tyuiu.KarpenkoNA.Sprint5\Tyuiu.KarpenkoNA.Sprint5.Task6.V20\bin\Debug\InPutDataFileTask6V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidStr()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\duplo\source\repos\Tyuiu.KarpenkoNA.Sprint5\Tyuiu.KarpenkoNA.Sprint5.Task6.V20\bin\Debug\InPutDataFileTask6V20.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
