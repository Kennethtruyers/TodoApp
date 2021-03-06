﻿using TodoApp.Code;
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
        private string _url = string.Empty;
        static Actions()
        {
            Driver = new InternetExplorerDriver();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            
            if (string.IsNullOrEmpty(_url))
            {
                _url = Environment.GetEnvironmentVariable("websiteUrl");
                if (string.IsNullOrEmpty(_url))
                {
                    // This is a local run
                    db.DeleteAll();
                    _url = "http://localhost:3159";
                }
            }

            Driver.Navigate().GoToUrl(_url);            
        }

        public static IWebDriver Driver {get; private set;}

    }
}
