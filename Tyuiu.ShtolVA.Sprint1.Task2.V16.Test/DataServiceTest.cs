﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.Task2.V16.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(6.28, res);

        }
    }
}
