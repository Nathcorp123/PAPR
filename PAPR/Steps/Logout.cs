using OpenQA.Selenium;
using PAPR.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PAPR.Steps
{
    [Binding]
    public class Logout
    {
        private IWebDriver driver;
        private ScenarioContext context;

        public Logout(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the PAPR website in Dev")]
        public void GivenOpenThePAPRWebsiteInDev()
        {
            driver.Navigate().GoToUrl("https://compres-dev.mmm.com/");
            System.Threading.Thread.Sleep(7000);
        }
        
        [Given(@"Click on the signin button present there\.")]
        public void GivenClickOnTheSigninButtonPresentThere_()
        {
            Thread.Sleep(6000);
        }
        
        [When(@"Provdide the emilid(.*) and password(.*)")]
        public void WhenProvdideTheEmilidAndPassword(string emailid, string password)
        {
            driver.FindElement(By.XPath(xpath.emaild)).SendKeys(emailid);
            driver.FindElement(By.XPath(xpath.next)).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(xpath.password)).SendKeys(password);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(xpath.clicksignin)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.multifactorclick)).Click();
            Thread.Sleep(8000);
        }
        
        [Then(@"Enter the gnerated OTP and make login into application")]
        public void ThenEnterTheGneratedOTPAndMakeLoginIntoApplication()
        {
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(xpath.authenticate)).Click();
            driver.FindElement(By.XPath(xpath.yes)).Click();
            Thread.Sleep(9000);
        }

        [Then(@"make logout from the application and close the browser\.")]
        public void ThenMakeLogoutFromTheApplicationAndCloseTheBrowser_()
        {
            driver.FindElement(By.XPath(xpath.selectpoweredair)).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath(xpath.Finditbutton)).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//a[normalize-space()='OVERVIEW']")).Click();
            driver.FindElement(By.XPath(xpath.signout)).Click();
            Thread.Sleep(9000);
            driver.Close();
        }


        
    }
}
