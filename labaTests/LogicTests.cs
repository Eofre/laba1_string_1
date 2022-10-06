using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba.Tests
{
    [TestClass()]
    public class LogicTests
    {
        

        [TestMethod()]
        public void SwapCharTest()
        {
            var message = Logic.SwapChar("ИРНИТУ");
            Assert.AreEqual("Итоговое слово: РИИНУТ", message);
        }
    }
}