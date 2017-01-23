using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace addressbook_web_tests.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int a = 1; a <= 100; a++)
            {
                System.Console.Out.Write(a + ", ");
            }
        }
    }
}
