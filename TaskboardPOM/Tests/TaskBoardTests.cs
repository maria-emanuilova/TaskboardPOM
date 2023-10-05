using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskboardPOM.Pages;

namespace TaskboardPOM.Tests
{
    public class TaskBoardTests: BaseTest
    {
        private TaskBoardPage TaskBoardPage;

        [SetUp]
        public void SetUp()
        {
            this.TaskBoardPage = new TaskBoardPage(driver);
            TaskBoardPage.OpenPage();
        }

        [Test]
        public void Test_IsTaskBoardPageOpen()
        {
            Assert.That(TaskBoardPage.isPageOpen, Is.True);
        }

        [Test]
        public void Test_VerifyFirstDoneTaskTitle()
        {
            Assert.That(TaskBoardPage.getFirstDoneTaskTitleText(), Is.EqualTo("Project skeleton"), "Check the first Done task Title");
        }
    }
}
