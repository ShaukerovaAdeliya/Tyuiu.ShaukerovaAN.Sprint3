using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint3.Task3.V19.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint3.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string str = "sxxrrg x vfrx";
            char rpb = 'x';
            char rpc = '2'; 

            string res = ds.ReplaceCharOnNum(str, rpb, rpc); 

            string wait = "s22rrg 2 vfr2"; 

            Assert.AreEqual(wait, res);
        }
    }
}
