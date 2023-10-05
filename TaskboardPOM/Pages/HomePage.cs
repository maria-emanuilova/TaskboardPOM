using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V115.WebAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskboardPOM.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://taskboard.mariaemanuilova.repl.co/";
        public IWebElement Tasks => driver.FindElement(By.XPath("//span[contains(.,'Tasks: ')]/b"));

        public string GetTasksCount()
        {
            return Tasks.Text;
        }
    }
}
