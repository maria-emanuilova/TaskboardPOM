using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskboardPOM.Pages
{
    public class TaskBoardPage : BasePage
    {
        public TaskBoardPage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://taskboard.mariaemanuilova.repl.co/boards";
        public IWebElement FirstDoneTask => driver.FindElement(By.Id("task1"));
        public IWebElement FirstDoneTaskTitle => FirstDoneTask.FindElements(By.ClassName("title")).First();
        public IWebElement FirstDoneTaskTitleContent => FirstDoneTaskTitle.FindElement(By.TagName("td"));
        public IWebElement OpenTasks => driver.FindElements(By.ClassName("task")).First();
        public IWebElement LastOpenTask => OpenTasks.FindElements(By.ClassName("task-entry")).Last();
        public IWebElement LastOpenTaskTitle => LastOpenTask.FindElement(By.TagName("td"));


        public string getFirstDoneTaskTitleText()
        {
            return FirstDoneTaskTitleContent.Text;
        }

        public string GetLastOpenTaskTitleText()
        {
            return LastOpenTaskTitle.Text;
        }
    }
}
