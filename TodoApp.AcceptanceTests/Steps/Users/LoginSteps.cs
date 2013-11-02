using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace TodoApp.AcceptanceTests.Steps.Users
{
    [Binding]
    public class LoginSteps
    {

        [Given(@"I enter the username '(.*)'")]
        public void WhenIEnterTheUsername(string userName)
        {
            Actions.Driver.FindElement(By.Id("loginName")).SendKeys(userName);
            
        }

        [Given(@"I enter the passowrd '(.*)'")]
        public void WhenIEnterThePassowrd(string password)
        {
            Actions.Driver.FindElement(By.CssSelector("#loginForm #Password")).SendKeys(password);
        }

        [When(@"I log in")]
        public void WhenILogIn()
        {
            Actions.Driver.FindElement(By.Id("loginForm")).Submit();
        }
    }
}
