@security
Feature: Login
	In order to access my todo lists
	As a registered user
	I want to be able to log in

Background: I am not logged in
	Given I am not logged in

Scenario: Log in with a wrong password
	Given I enter the username 'Kenneth'
	And I enter the passowrd 'wrongpassword'
	When I log in
	Then the message 'The user name or password provided is incorrect.' should be shown
