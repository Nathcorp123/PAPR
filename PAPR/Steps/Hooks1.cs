using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PAPR.Steps
{
    [Binding]
    public class Hooks1
    {
        private readonly IObjectContainer iob;
        public IWebDriver driver;
        static int rowCount = 3;
        public Hooks1(IObjectContainer iob)
        {
            this.iob = iob;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(@"C:\Users\manish.verma\source\repos\Firestop\Firestop\Chrome");
            //ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            iob.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()

        {

            var driver = iob.Resolve<IWebDriver>();
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
            if (scenarioName.Equals("Open Respiratory website and make login into it"))
            {
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    writedatatoexcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    writedatatoexcel.ExcelCode(res, msg, rowCount);

                }
            }
            else if (scenarioName.Equals("Select any Respiratory Category and show the results"))
            {
                rowCount = 4;
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    writedatatoexcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    writedatatoexcel.ExcelCode(res, msg, rowCount);

                }
            }
            else if (scenarioName.Equals("Open Respiratory Website make login into application then Logout from application"))
            {
                rowCount = 5;
                if (ScenarioContext.Current.TestError == null)
                {
                    string msg = "Data Validated Successfully";
                    var res = "PASS";

                    writedatatoexcel.ExcelCode(res, msg, rowCount);

                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    string msg = ScenarioContext.Current.TestError.Message;
                    var res = "FAIL";

                    writedatatoexcel.ExcelCode(res, msg, rowCount);

                }
            }
        }
    }
}
            
        
    


    
        
    
 














