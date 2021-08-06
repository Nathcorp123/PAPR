using OpenQA.Selenium;
using OtpNet;
using PAPR.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PAPR.Steps
{
    [Binding]
    public class PAPRSteps
    {
        private IWebDriver driver;
        private ScenarioContext context;
        
        public PAPRSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the PAPR website")]
        public void GivenOpenThePAPRWebsite()
        {
           driver.Navigate().GoToUrl("https://compres-dev.mmm.com/");
            System.Threading.Thread.Sleep(5000);
        }
        
        [Given(@"Click on the signin button")]
        public void GivenClickOnTheSigninButton()
        {
            //driver.FindElement(By.XPath(xpath.signin)).Click();
            Thread.Sleep(4000);

            
        }

        [When(@"Enter the emailid(.*) and password(.*)")]
        public void WhenEnterTheEmailIdAndPassword(string emailid, string password)
        {
            driver.FindElement(By.XPath(xpath.emaild)).SendKeys(emailid);
            driver.FindElement(By.XPath(xpath.next)).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(xpath.password)).SendKeys(password);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(xpath.clicksignin)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.multifactorclick)).Click();
            Thread.Sleep(10000);
        }


       
        
        [Then(@"Provide the generated OTP and make login into application")]
        public void ThenProvideTheGeneratedOTPAndMakeLoginIntoApplication()
        {
            //var otpKeyStr = "6jm7n6xwitpjooh7ihewyyzeux7aqmw2";
            //var otpKeyBytes = Base32Encoding.ToBytes(otpKeyStr);
            //var totp = new Totp(otpKeyBytes);
            //var twoFactorCode = totp.ComputeTotp();
            //var input = driver.FindElement(By.XPath(xpath.otp));
            //input.SendKeys(twoFactorCode);
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(xpath.authenticate)).Click();
            driver.FindElement(By.XPath(xpath.yes)).Click();
            Thread.Sleep(8000);
            driver.Close();
           



        }
    }
}
