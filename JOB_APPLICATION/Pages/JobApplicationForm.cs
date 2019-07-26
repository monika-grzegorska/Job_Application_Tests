using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace JOB_APPLICATION.Pages
{
    class JobApplicationForm
    {
        private IWebDriver driver;

        public JobApplicationForm(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //-------------



        //-------------
        public void goToFormPage()
        {
            driver.Navigate().GoToUrl("https://www.wufoo.com/gallery/templates/forms/job-application/");
        }

    }
}

