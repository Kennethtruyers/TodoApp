using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TodoApp.AcceptanceTests.Utils;

namespace TodoApp.AcceptanceTests.Steps
{
    [Binding]
    class CommonSteps
    {

        [When(@"I refresh the page")]
        public void WhenIRefreshThePage()
        {
            Actions.Driver.Navigate().Refresh();
        }

        [Then(@"I should be redirected to the list page")]
        public void ThenIShouldBeRedirectedToTheListPage()
        {
            Assert.That(Actions.Driver.FindElement(By.CssSelector(".username")).Displayed, Is.True);
        }

        [Then(@"the message '(.*)' should be shown")]
        public void ThenTheMessageShouldBeShown(string message)
        {
            Assert.That(Actions.Driver.FindElement(By.CssSelector(".validation-summary-errors")).Text, Is.EqualTo(message));
        }

        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            
            if (IsLoggedIn())
            {
                Actions.Driver.FindElement(By.Id("logoutForm")).Submit();
            }
            Actions.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            if (!IsLoggedIn())
            {
                Actions.Driver.FindElement(By.Id("showRegister")).Click();
                
                Actions.Driver.FindVisibleElement(By.Id("registerName"), 5).SendKeys("UserTest");
                
                var pwd = Actions.Driver.FindVisibleElement(By.CssSelector("#registerForm #Password"), 5);
                pwd.Click();
                pwd.SendKeys("password");

                var pwdConfirm = Actions.Driver.FindVisibleElement(By.Id("ConfirmPassword"), 5);
                pwdConfirm.Click();
                pwdConfirm.SendKeys("password");

                Actions.Driver.FindElement(By.Id("registerForm")).Submit();
            }
        }

        private bool IsLoggedIn()
        {
            Actions.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            var loggedIn = Actions.Driver.FindElements(By.Id("logoutForm")).Count > 0;
            Actions.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            return loggedIn;
        }


    }
}
