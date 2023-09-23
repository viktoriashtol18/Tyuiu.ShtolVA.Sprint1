using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint1.Task3.V7.Lib;

namespace Tyuiu.ShtolVA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 25;
            double wait = 26.67;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(wait, res);
        }
    }
}
