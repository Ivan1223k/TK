using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var NewWindow = new MainWindow();

            Assert.IsTrue(NewWindow.Calculatee("20","20","20"));

            Assert.IsFalse(NewWindow.Calculatee("40", "20", "20"));
            Assert.IsFalse(NewWindow.Calculatee("20", "40", "20"));
            Assert.IsFalse(NewWindow.Calculatee("20", "20", "40"));
            Assert.IsFalse(NewWindow.Calculatee("", "", ""));

        }
    }
}
