using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TodoApp.AcceptanceTests.Utils;

namespace TodoApp.AcceptanceTests.Steps.User
{
    [Binding]
    public class RegisterSteps
    {
        [Given(@"I am on the sign up page")]
        public void GivenIAmOnTheSignUpPage()
        {
            Actions.Driver.FindElement(By.Id("showRegister")).Click();
        }

        [Given(@"I have entered username '(.*)'")]
        public void GivenIHaveEnteredUsername(string userName)
        {
            Actions.Driver.FindVisibleElement(By.Id("registerName"), 5).SendKeys(userName);
        }

        [Given(@"a password '(.*)'")]
        public void GivenAPassword(string password)
        {
            var pwd = Actions.Driver.FindVisibleElement(By.CssSelector("#registerForm #Password"), 5);
            pwd.Click();
            pwd.SendKeys(password);
        }

        [Given(@"a password confirmation '(.*)'")]
        public void GivenAPasswordConfirmation(string passwordConfirmation)
        {
            var pwdConfirm = Actions.Driver.FindVisibleElement(By.Id("ConfirmPassword"), 5);
            pwdConfirm.Click();
            pwdConfirm.SendKeys(passwordConfirmation);
        }

        [When(@"I press sign up")]
        public void WhenIPressSignUp()
        {
            Actions.Driver.FindElement(By.Id("registerForm")).Submit();
        }
    }
}
