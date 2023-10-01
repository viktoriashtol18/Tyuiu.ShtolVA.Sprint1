using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint1.Task4.V3.Lib;

namespace Tyuiu.ShtolVA.Sprint1.Task4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
