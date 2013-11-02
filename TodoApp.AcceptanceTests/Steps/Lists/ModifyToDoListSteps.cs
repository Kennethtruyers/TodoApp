using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TodoApp.AcceptanceTests.Utils;

namespace TodoApp.AcceptanceTests.Steps.Lists
{
    [Binding]
    public class CreateToDoListSteps
    {
        private string _name; 

        [When(@"I rename a todo list to '(.*)'")]
        public void WhenIRenameATodoListTo(string name)
        {
            _name = name;
            var element = Actions.Driver.FindVisibleElement(By.CssSelector(".todoList form input"), 5);
            element.Clear();
            element.SendKeys(_name);
            element.SendKeys(Keys.Tab);
        }

        [Then(@"the name of the list should be updated")]
        public void ThenTheNameOfTheListShouldBeUpdated()
        {
            Assert.That(Actions.Driver.FindVisibleElement(By.CssSelector(".todoList form input"), 5).GetAttribute("value"), Is.EqualTo(_name));
        }


        [Then(@"the todo list has an error message '(.*)'")]
        public void ThenTheTodoListHasAnErrorMessage(string message)
        {
            Assert.That(Actions.Driver.FindElement(By.CssSelector(".todoList > p.error")).Text, Is.EqualTo(message));
        }


    }
}
