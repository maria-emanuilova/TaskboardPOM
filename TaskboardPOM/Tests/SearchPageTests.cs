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
        private SearchPage SearchPage;

        [SetUp]
        public void SetUp()
        {
            this.SearchPage = new SearchPage(driver);
            SearchPage.OpenPage();
        }

        [Test]
        public void Test_CheckSearch_FirstHomeTaskTitle()
        {
            SearchPage.TypeKeyword("home");
            SearchPage.ClickSearch();

            Assert.That(SearchPage.GetCellFirstTaskFoundText(), Is.EqualTo("Title"));
            Assert.That(SearchPage.GetFirstTaskFoundTitle(), Is.EqualTo("Home page"));
        }

        [Test]
        public void Test_CheckSearch_NoResults()
        {
            SearchPage.TypeKeyword("missing" + DateTime.Now.Ticks);
            SearchPage.ClickSearch();

            Assert.That(SearchPage.GetSearchResultText(), Is.EqualTo("No tasks found."), "Check results text content.");
        }
    }
}
