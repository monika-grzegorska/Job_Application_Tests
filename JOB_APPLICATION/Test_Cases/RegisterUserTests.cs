using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using JOB_APPLICATION.Pages;

namespace JOB_APPLICATION
{
    public class RegisterUserTests
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
            HomePage home = new HomePage(driver);
            home.goToPage();

            //ACT
            SignUp signUp = home.goToSignUpPage();
        }
        [Test]
        public void JOB_APPLICATION_Given_CreatingNewUserAccount_When_GivenValidInformation_Then_OpenUserPanel()
        {
            //ARRANGE
            HomePage home = new HomePage(driver);
            home.goToPage();
            SignUp signUp = home.goToSignUpPage();
            //ACT
            signUp.createAnAccountAndGoToUserPanel();
        }
        [Test]
        public void JOB_APPLICATION_Given_TryingToSignUp_When_GivenInalidInformation_Then_InformationOfInvalidDataPopUp()
        {
            //ARRANGE
            HomePage home = new HomePage(driver);
            home.goToPage();
            SignUp signUp = home.goToSignUpPage();
            //ACT
            signUp.giveInvalidInformation();
            //ASSERT
            Assert.IsTrue(driver.Url.Contains("register"));
        }
        [TearDown]
        public void TearDown()
        {
            //driver.Close();
        }

    }
}

