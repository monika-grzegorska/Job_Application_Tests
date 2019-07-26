using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace JOB_APPLICATION.Pages
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //-------------
        [FindsBy(How = How.CssSelector, Using = "div > div > div > a.c-btn.c-btn--primary")]
        private IWebElement signUpButton;


        //-------------
        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.wufoo.com/gallery/templates/forms/job-application/");
        }

        public SignUp goToSignUpPage()
        {
            signUpButton.Click();
            return new SignUp(driver);
        }
    }
}
