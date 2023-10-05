using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskboardPOM.Pages;

namespace TaskboardPOM.Tests
{
    public class CreatePageTests: BaseTest
    {
        private CreatePage CreatePage;
        private TaskBoardPage TaskBoardPage;
        private HomePage HomePage;
        private BasePage BasePage;

        [SetUp]
        public void SetUp()
        {
            this.BasePage = new BasePage(driver);
            this.CreatePage = new CreatePage(driver);
            this.TaskBoardPage = new TaskBoardPage(driver);
            this.HomePage = new HomePage(driver);
            CreatePage.OpenPage();
        }

        [Test]
        public void Test_Create_TryEmptyTitle()
        {
            CreatePage.FillDescription("This is test description");
            CreatePage.ClickCreate();

            Assert.That(CreatePage.getErrorMessageText(), Is.EqualTo("Error: Title cannot be empty!"));
        }

        [Test]
        public void Test_Create_ValidTask()
        {
            HomePage.OpenPage();
            var TasksCount = int.Parse(HomePage.GetTasksCount());

            CreatePage.OpenPage();
            string title = "First task for the day" + DateTime.Now.Ticks;
            CreatePage.FillTitle(title);
            CreatePage.FillDescription("to do");
            CreatePage.ClickCreate();
            Assert.That(TaskBoardPage.GetLastOpenTaskTitleText(), Is.EqualTo(title), "Check new task title");

            BasePage.ClickHome();

            var NewTasksCount = int.Parse(HomePage.GetTasksCount());
            Assert.That(NewTasksCount, Is.EqualTo(TasksCount + 1), "Verify task count is increased by 1");
        }
    }
}
