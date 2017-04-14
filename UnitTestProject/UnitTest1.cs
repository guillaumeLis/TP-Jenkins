using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsConsole;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Program.Add(5, 4);
        }

        public void TestDivision()
        {
            Program.Division(4, 2);
        }
    }
}
