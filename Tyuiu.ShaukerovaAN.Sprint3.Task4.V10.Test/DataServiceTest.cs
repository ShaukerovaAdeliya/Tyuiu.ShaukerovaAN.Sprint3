using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint3.Task4.V10.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startvalue = -5 ;
            int stopValue = 5 ;

            double res = ds.Calculate(startvalue, stopValue);

            double wait = 0.014 ;
            Assert.AreEqual(wait, res);
        }
    }
}
