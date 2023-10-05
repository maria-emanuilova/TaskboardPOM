using NUnit.Framework;
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
        private HomePage HomePage;

        [SetUp]
        public void SetUp()
        {
            this.HomePage = new HomePage(driver);
            HomePage.OpenPage();
        }

        [Test]
        public void Test_IsPageOpen()
        {
            Assert.That(HomePage.isPageOpen(), Is.True);
        }
    }
}
