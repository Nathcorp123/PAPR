using OpenQA.Selenium;
using PAPR.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PAPR.Steps
{
    [Binding]
    public class findit
    {
        private IWebDriver driver;
        private ScenarioContext context;

        public findit(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the PAPR websites")]
        public void GivenOpenThePAPRWebsites()
        {
            driver.Navigate().GoToUrl("https://compres-dev.mmm.com/");
            System.Threading.Thread.Sleep(7000);
        }
        
        [Given(@"Click on the siggnin button")]
        public void GivenClickOnTheSiggninButton()
        {
            Thread.Sleep(6000);
        }
        
        [When(@"Enter the emilid(.*) and password(.*)")]
        public void WhenEnterTheEmilidAndPassword(string emailid, string password)
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
        
        [Then(@"Provide the gnerated OTP and make login into application")]
        public void ThenProvideTheGneratedOTPAndMakeLoginIntoApplication()
        {
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(xpath.authenticate)).Click();
            driver.FindElement(By.XPath(xpath.yes)).Click();
            Thread.Sleep(9000);
           
        }

        [Then(@"Select any Respiratory category and get the results")]
        public void ThenSelectAnyRespiratoryCategoryAndGetTheResults()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.FindElement(By.XPath(xpath.selectpoweredair)).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath(xpath.Finditbutton)).Click();
            Thread.Sleep(15000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(9000);
            driver.FindElement(By.XPath(xpath.Markitinginfo)).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath(xpath.Basicinfo)).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath(xpath.PhysicalAttribute)).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath(xpath.overview)).Click();
            Thread.Sleep(9000);
            driver.Navigate().Back();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//a[normalize-space()='OVERVIEW']")).Click();
            driver.FindElement(By.XPath("//input[@id='cat_2']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//button[normalize-space()='FIND IT']")).Click();
            Thread.Sleep(9000);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//a[normalize-space()='Marketing Information']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//div[@data-target='#collapseOne']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//div[@data-target='#collapseTwo']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//a[normalize-space()='OVERVIEW']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//input[@id='cat_3']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//button[normalize-space()='FIND IT']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//a[normalize-space()='OVERVIEW']")).Click();


            //driver.FindElement(By.XPath(xpath.signout)).Click();
            Thread.Sleep(9000);
            driver.Close();
        }
    }
}
