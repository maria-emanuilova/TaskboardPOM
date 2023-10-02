using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TaskboardPOM.Pages
{
    public class BasePage
    {
        protected readonly WebDriver driver;

        public virtual string BaseUrl { get; }
        public IWebElement LinkHome => driver.FindElement(By.LinkText("Home"));
        public IWebElement LinkTaskBoard => driver.FindElement(By.LinkText("Task Board"));
        public IWebElement LinkCreate => driver.FindElement(By.LinkText("Create"));
        public IWebElement LinkSearch => driver.FindElement(By.LinkText("Search"));

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void ClickHome()
        {
            LinkHome.Click();
        }

        public void ClickTaskBoard()
        {
            LinkTaskBoard.Click();
        }

        public void ClickCreate()
        {
            LinkCreate.Click();
        }

        public void ClickSearch()
        {
            LinkSearch.Click();
        }

        public bool isPageOpen()
        {
            return driver.Url == BaseUrl;
        }
    }
}
