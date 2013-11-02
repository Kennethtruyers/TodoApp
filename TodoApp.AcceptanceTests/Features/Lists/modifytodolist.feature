Feature: Modify To do list
	In order to organize my lists
	As a logged in user
	I want to be be able to rename a todo lists

Background: The user is registered and logged in
	Given I am logged in

Scenario: Modifying a todo list
	When I rename a todo list to 'My new todolist'
	And I refresh the page
	Then the name of the list should be updated

Scenario: Modifying a todo list with an empty name
	When I rename a todo list to ''
	Then the todo list has an error message 'Error updating the todo list title. Please make sure it is non-empty.'
