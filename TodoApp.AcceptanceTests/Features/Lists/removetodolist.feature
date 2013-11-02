Feature: removetodolist
	In order to remove obsolete lists
	As a registered user
	I want to be able to remove an existing list

Background: The user is registered and logged in
	Given I am logged in

@mytag
Scenario: Deleting a todo list
	When I delete a list
	Then there should be 0 lists
