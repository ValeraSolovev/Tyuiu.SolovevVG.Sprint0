using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SolovevVG.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Валерий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Валерий", res);
        }
    }
}
