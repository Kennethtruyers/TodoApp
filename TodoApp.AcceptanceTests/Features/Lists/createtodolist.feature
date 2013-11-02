Feature: Create To do list
	In order to organize my list
	As a logged in user
	I want to be be able to create new todo lists

Background: The user is registered and logged in
	Given I am logged in

Scenario: Adding a todo list
	When I add a todo list
	Then a list with the name 'My todos' should be created
