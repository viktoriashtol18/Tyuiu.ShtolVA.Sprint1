using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ShtolVA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    { 
        [TestMethod]
        public void ValidExpression()
    {
        int x = 1051981;
        DataService ds = new DataService();
        double res = ds.Calculate(x);

        int result = Convert.ToInt32(res);

        int wait = 9;
        Assert.AreEqual(wait, result);

        
        }
    }
}
