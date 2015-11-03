Feature: test_the_internet
	In order to do some stuff
	As a human
	I want to be able to log into the internet

@feature_one
Scenario: Successful login
	Given I have entered 'username' and 'password' into the internet
	When I login
	Then I should get a message to say that login was successful
