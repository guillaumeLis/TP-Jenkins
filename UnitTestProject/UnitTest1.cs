﻿using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsConsole;
using NUnit.Framework;


namespace UnitTestProject
{
    public class UnitTest1
    {
        [Test]
        public void TestAdd()
        {
            Program prog = new Program();
            int result = prog.Add(5, 4);
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void TestDivision()
        {
            Program prog = new Program();
            float result = prog.Division(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void TestSoustraction()
        {
            Program prog = new Program();
            int result = prog.Soustraction(4, 3);
            Assert.That(result, Is.EqualTo(1));
        }

    }


}