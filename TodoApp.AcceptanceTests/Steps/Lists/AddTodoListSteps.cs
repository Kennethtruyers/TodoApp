using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TodoApp.AcceptanceTests.Steps.Lists
{
    [Binding]
    class AddTodoListSteps
    {
        [When(@"I add a todo list")]
        public void WhenIAddATodoList()
        {
            Actions.Driver.FindElement(By.CssSelector("#main-content > button")).Click();
        }

        [Then(@"a list with the name '(.*)' should be created")]
        public void ThenAListWithTheNameShouldBeCreated(string listName)
        {
            Assert.That(Actions.Driver.FindElements(By.CssSelector(".todoList header input"))[0].GetAttribute("value"), Is.EqualTo(listName));
        }

    }
}
