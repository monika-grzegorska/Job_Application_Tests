using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace JOB_APPLICATION.Pages
{
   public class SignUp
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SignUp(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement signUpEmail;
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement signUpPassword;
        [FindsBy(How = How.Id, Using = "wufooName")]
        private IWebElement signUpUsername;
        [FindsBy(How = How.Id, Using = "saveForm")]
        private IWebElement signUpButton;

        public UserPanel createAnAccountAndGoToUserPanel()
        {
            signUpEmail.SendKeys("bubu@bobo.com");
            signUpPassword.SendKeys("123456765Harry");
            signUpUsername.SendKeys("HarryPotterIsThaBest");
            signUpButton.Click();
            return new UserPanel(driver);
        }
        public SignUp giveInvalidInformation()
        {
            signUpEmail.SendKeys("bububobo.com");
            signUpPassword.SendKeys("12345");
            signUpUsername.SendKeys("HP");
            signUpButton.Click();
            return new SignUp(driver);
        }


    }

}

