using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace JOB_APPLICATION.Pages
{
    public class UserPanel
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public UserPanel(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            PageFactory.InitElements(driver, this);
        }

    }
}
