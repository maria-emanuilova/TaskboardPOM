using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskboardPOM.Pages;

namespace TaskboardPOM.Tests
{
    public class SearchPageTests : BaseTest
    {
        private SearchPage page;

        [SetUp]
        public void SetUp()
        {
            this.page = new SearchPage(driver);
            page.OpenPage();
        }

        [Test]
        public void Test_CheckSearch_FirstHomeTaskTitle()
        {
            page.TypeKeyword("home");
            page.ClickSearch();

            Assert.That(page.GetCellFirstTaskFoundText(), Is.EqualTo("Title"));
            Assert.That(page.GetFirstTaskFoundTitle(), Is.EqualTo("Home page"));
        }

        [Test]
        public void Test_CheckSearch_NoResults()
        {
            page.TypeKeyword("missing" + DateTime.Now.Ticks);
            page.ClickSearch();

            Assert.That(page.GetSearchResultText(), Is.EqualTo("No tasks found."), "Check results text content.");
        }
    }
}
