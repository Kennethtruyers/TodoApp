using TodoApp.Code;
using TodoApp.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace TodoApp.AcceptanceTests
{
    [Binding]
    public class Actions
    {
        private static Db db = new Db();

        static Actions()
        {
            Driver = new InternetExplorerDriver();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            db.DeleteAll();
            Driver.Navigate().GoToUrl("http://localhost:3159");            
        }

        public static IWebDriver Driver {get; private set;}

    }
}
