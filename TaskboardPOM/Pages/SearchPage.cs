using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskboardPOM.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://taskboard.mariaemanuilova.repl.co/tasks/search";
        public IWebElement FieldSearchByKeyword => driver.FindElement(By.Id("keyword"));
        public IWebElement ButtonSearch => driver.FindElement(By.Id("search"));

        public IWebElement FirstTaskFound => driver.FindElements(By.ClassName("task")).First();
        public IWebElement TextFirstTaskFoundTitle => FirstTaskFound.FindElements(By.TagName("td")).First();
        public IWebElement CellFirstTaskFoundTitle => FirstTaskFound.FindElements(By.TagName("th")).First();
        public IWebElement SearchResult => driver.FindElement(By.Id("searchResult"));


        public void TypeKeyword (string keyword)
        {
            FieldSearchByKeyword.SendKeys(keyword);
        }

        public void ClickSearch()
        {
            ButtonSearch.Click();
        }

        public string GetFirstTaskFoundTitle()
        {
            return TextFirstTaskFoundTitle.Text;
        }

        public string GetCellFirstTaskFoundText()
        {
            return CellFirstTaskFoundTitle.Text;
        }

        public string GetSearchResultText()
        {
            return SearchResult.Text;
        }
    }
}
