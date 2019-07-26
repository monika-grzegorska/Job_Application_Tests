using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace JOB_APPLICATION.Pages
{
    class JobApplicationForm
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public JobApplicationForm(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        //-------------
        [FindsBy(How = How.Id, Using = "Field1")]
        private IWebElement applyingPositionList; //Required
        [FindsBy(How = How.Id, Using = "Field2")]
        private IWebElement firstName;            //Required
        [FindsBy(How = How.Id, Using = "Field3")]
        private IWebElement lastName;
        [FindsBy(How = How.Id, Using = "Field4")]
        private IWebElement emailAdress;          //Required

        [FindsBy(How = How.Id, Using = "Field5")]
        private IWebElement firstPartOfPhoneNumber;
        [FindsBy(How = How.Id, Using = "Field5-1")]
        private IWebElement secondPartOfPhoneNumber;
        [FindsBy(How = How.Id, Using = "Field5-2")]
        private IWebElement thirdPartOfPhoneNumber;

        [FindsBy(How = How.Id, Using = "Field15_0")]
        private IWebElement relocationRadioButtonYes; //Required
        [FindsBy(How = How.Id, Using = "Field15_1")]
        private IWebElement relocationRadioButtonNo; //Required

        [FindsBy(How = How.Id, Using = "Field7")]
        private IWebElement resumeUploadButton;   //Required
        [FindsBy(How = How.Id, Using = "Field8")]
        private IWebElement coverLetterButton;

        [FindsBy(How = How.Id, Using = "Field9")]
        private IWebElement linkedinURL;
        [FindsBy(How = How.Id, Using = "Field10")]
        private IWebElement twitterURL;
        [FindsBy(How = How.Id, Using = "Field11")]
        private IWebElement webURL;

        [FindsBy(How = How.Id, Using = "Field12")]
        private IWebElement aboutField;
        [FindsBy(How = How.Id, Using = "saveForm")]
        private IWebElement submitButton;

        //-------------
        public void openFormPage()
        {
            driver.Navigate().GoToUrl("https://www.wufoo.com/gallery/templates/forms/job-application/");
        }

        public void fillJobFormWithAllInformations()
        {
            IWebElement iframe = driver.FindElement(By.Id("wufooFormr11oib2u1w948kb"));
            driver.SwitchTo().Frame(iframe);
            new SelectElement(applyingPositionList).SelectByText("Marketing Manager");
            

            firstName.SendKeys("Monika");
            lastName.SendKeys("Grzegórska");
            emailAdress.SendKeys("monika@grzegorska.pro");

            firstPartOfPhoneNumber.SendKeys("531");
            secondPartOfPhoneNumber.SendKeys("279");
            thirdPartOfPhoneNumber.SendKeys("284");

            relocationRadioButtonNo.Click();

            resumeUploadButton.SendKeys(@"D:\Monika\Tests\JOB_APPLICATION\JOB_APPLICATION\Monika_Grzegórska_QA (2).pdf");
        }

    }
}

