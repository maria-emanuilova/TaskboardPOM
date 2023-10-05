using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskboardPOM.Pages
{
    public class CreatePage : BasePage
    {
        public CreatePage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://taskboard.mariaemanuilova.repl.co/tasks/create";
        public IWebElement InputDescription => driver.FindElement(By.Id("description"));
        public IWebElement InputTitle => driver.FindElement(By.Id("title"));
        public IWebElement ButtonCreate => driver.FindElement(By.Id("create"));
        public IWebElement ErrorMessage => driver.FindElement(By.ClassName("err"));
        



        public void FillDescription(string description)
        {
            InputDescription.SendKeys(description);
        }

        public void FillTitle(string title)
        {
            InputTitle.SendKeys(title);
        }

        public void ClickCreate()
        {
            ButtonCreate.Click();
        }

        public string getErrorMessageText()
        {
            return ErrorMessage.Text;
        }

    }
}
