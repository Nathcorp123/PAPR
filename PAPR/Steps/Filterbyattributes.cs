using OpenQA.Selenium;
using PAPR.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using System.Text.RegularExpressions;

namespace PAPR.Steps
{
    [Binding]
    public class Filterbyattributes
    {
        private IWebDriver driver;
        private ScenarioContext context;

        public Filterbyattributes(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the PAPR website application")]
        public void GivenOpenThePAPRWebsiteApplication()
        {
            driver.Navigate().GoToUrl("https://compres-dev.mmm.com/");
            System.Threading.Thread.Sleep(7000);
        }

        [Given(@"Click on the signin button there")]
        public void GivenClickOnTheSigninButtonThere()
        {
            Thread.Sleep(6000);
        }

        [When(@"Enter the emailid(.*) and passwoord(.*)")]
        public void WhenEnterTheEmailidAndPasswoord(string emailid, string password)
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

        [Then(@"Provide the gnerted OTP and make login into application")]
        public void ThenProvideTheGnertedOTPAndMakeLoginIntoApplication()
        {
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(xpath.authenticate)).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(xpath.yes)).Click();
            Thread.Sleep(9000);
        }

        [Then(@"Select any Respiratory category and verify filter by attributes\.")]
        public void ThenSelectAnyRespiratoryCategoryAndVerifyFilterByAttributes_()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.FindElement(By.XPath(xpath.selectpoweredair)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(xpath.Finditbutton)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='attrid_6']")).Click();
            Thread.Sleep(5000);
            string discon = driver.FindElement(By.XPath("//label[normalize-space()='Discontinued']")).Text;
            Thread.Sleep(5000);
            string com = driver.FindElement(By.XPath("//div[@id='v_filterby']")).Text;
            string com2 = com.Replace(" [x]  ", "");
            //var com3 = Regex.Replace(com2, @"(\s+|:|)", "");
            Console.WriteLine(discon.Length + "\n" + com2.Length);
            if (discon == com2)
            {
                Console.WriteLine("Matched");
            }
            else
            {
                Console.Write("Not Matched");
            }

            Thread.Sleep(9000);
            driver.Close();





        }
    }
}
