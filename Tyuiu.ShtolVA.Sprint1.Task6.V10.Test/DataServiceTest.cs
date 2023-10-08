using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.ShtolVA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "сегодня пятница,завтра суббота";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strTest);
            string wait = "сегдня пятица,завтра субота";
            Assert.AreEqual(wait, res);
        }
    }
}
