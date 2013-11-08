using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace TodoApp.AcceptanceTests.Steps.Lists
{
    [Binding]
    public class RemovetodolistSteps
    {
        int _totallists;

        [When(@"I delete a list")]
        public void WhenIDeleteAList()
        {
            _totallists = Actions.Driver.FindElements(By.CssSelector(".todoList")).Count;
            Actions.Driver.FindElement(By.CssSelector(".deletelist")).Click();
        }

        [Then(@"there should be (.*) lists")]
        public void ThenThereShouldBeLists(int count)
        {
            Assert.That(Actions.Driver.FindElements(By.CssSelector(".todoList")).Count, Is.EqualTo(_totallists - 1));
        }
    }
}
