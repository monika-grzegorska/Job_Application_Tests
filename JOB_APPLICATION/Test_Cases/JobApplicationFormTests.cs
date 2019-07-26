using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using JOB_APPLICATION.Pages;
namespace JOB_APPLICATION.Test_Cases
{
    class JobApplicationFormTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void JOB_APPLICATION_Given_GoSignUpPage_When_ClickOnSignUpButton_Then_OpenSignUpPage()
        {
            //ARRANGE
            JobApplicationForm jobForm = new JobApplicationForm(driver);
            jobForm.openFormPage();
            //ACT
            jobForm.fillJobFormWithAllInformations();
        }
    }
}
