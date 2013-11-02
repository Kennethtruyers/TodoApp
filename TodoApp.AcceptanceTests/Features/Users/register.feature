@security
Feature: Register
	In order to get access to the application
	As a user
	I want to be able to sign up

Background: I am not logged in
	Given I am not logged in

Scenario: Register
	Given I am on the sign up page
	And I have entered username 'KennethTest2'
	And a password 'testpassword'
	And a password confirmation 'testpassword'
	When I press sign up
	Then I should be redirected to the list page

Scenario: Register with a short password
	Given I am on the sign up page
	And I have entered username 'KennethTest2'
	And a password 'test'
	And a password confirmation 'test'
	When I press sign up
	Then the message 'The Password must be at least 6 characters long.' should be shown

Scenario: Register without a username
	Given I am on the sign up page
	And I have entered username ''
	And a password 'testtest'
	And a password confirmation 'testtest'
	When I press sign up
	Then the message 'The User name field is required.' should be shown
