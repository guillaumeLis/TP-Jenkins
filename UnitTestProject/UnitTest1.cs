using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsConsole;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestAdd()
        {
            //Test d'addition
            Program prog = new Program();
            int result = prog.Add(5, 4);
            Assert.AreEqual(result, 9);
        }

        [Test]
        public void TestDivision()
        {
            Program prog = new Program();
            float result = prog.Division(4f, 2f);
            Assert.AreEqual(result, 2f);
        }

        [Test]
        public void TestSoustraction()
        {
            Program prog = new Program();
            int result = prog.Soustraction(4, 3);
            Assert.AreEqual(result, 1);
        }

    }


}
