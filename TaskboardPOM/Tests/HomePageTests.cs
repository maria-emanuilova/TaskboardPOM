﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskboardPOM.Pages;

namespace TaskboardPOM.Tests
{
    public class HomePageTests : BaseTest
    {
        private HomePage page;

        [SetUp]
        public void SetUp()
        {
            this.page = new HomePage(driver);
            page.OpenPage();
        }

        [Test]
        public void Test_IsPageOpen()
        {
            Assert.That(page.isPageOpen(), Is.True);
        }
    }
}
